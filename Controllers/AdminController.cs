using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebAppOglas.Data;
using WebAppOglas.Models;

namespace WebAppOglas.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        WebAppOglasContext _ctx;
        private RoleManager<IdentityRole> roleManager;
        private UserManager<IdentityUser> userManager;

        public AdminController(RoleManager<IdentityRole> roleMgr, UserManager<IdentityUser> userMgr, WebAppOglasContext ctx)
        {
            roleManager = roleMgr;
            userManager = userMgr;
            _ctx = ctx;
        }
        
        public IActionResult Index()
        {        
           var user = userManager.Users.ToList();

            return View(user.ToList());
        }


        // GET: AdminUsers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {

            if (id == null || userManager.Users == null)
            {
                return NotFound();
            }

            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(IdentityUser idUser)
        {
            IdentityUser user = await userManager.FindByIdAsync(idUser.Id);

            if (user == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {                                                         
                    if(user.UserName != null && user.Email != null && user.PhoneNumber != null )
                    {
                        IdentityResult result = await userManager.UpdateAsync(user);

                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ErrorViewModel error = new ErrorViewModel();
                            error.ToString();
                        }
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AspNetUserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }


        public async Task<IActionResult> Details(string id)
        {
            if (id == null || userManager.Users == null)
            {
                return NotFound();
            }

            var user = await userManager.Users.FirstOrDefaultAsync(m => m.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }


        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || userManager.Users == null)
            {
                return NotFound();
            }

            IdentityUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    TempData["Deleted"] = "Successfuly deleted";
                    return RedirectToAction("Index");
                }

                else
                    TempData["Deleted"] = "User not deleted!";
            }
            else
                ModelState.AddModelError("", "User Not Found");
     
            return View(user);
        }



        private void Errors(IdentityResult result)
        {
            RedirectToAction("/Error");
        }

        private bool AspNetUserExists(string id)
        {
            return (userManager.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
