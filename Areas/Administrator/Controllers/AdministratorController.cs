using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebAppOglas.Data;

namespace WebAppOglas.Areas.Preview.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles ="Admin")]
    public class AdministratorController : Controller
    {
        WebAppOglasContext _ctx;
        private RoleManager<IdentityRole> roleManager;
        private UserManager<IdentityUser> userManager;

        public AdministratorController(RoleManager<IdentityRole> roleMgr, UserManager<IdentityUser> userMgr, WebAppOglasContext ctx)
        {
            roleManager = roleMgr;
            this.userManager = userMgr;
            _ctx = ctx;
        }
        
        public IActionResult Index()
        {        
           var user = _ctx.Users.ToList();

            return View(user.ToList());
        }


        // GET: AdminUsers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {

            if (id == null || _ctx.Users == null)
            {
                return NotFound();
            }


            var user = await _ctx.Users.FindAsync(id);



            if (user == null)
            {
                return NotFound();
            }


            return View(user);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, IdentityUser user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _ctx.Update(user);

                    await _ctx.SaveChangesAsync();
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
            if (id == null || _ctx.Users == null)
            {
                return NotFound();
            }

            var user = await _ctx.Users.FirstOrDefaultAsync(m => m.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }


        // GET: AdminUsers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _ctx.Users == null)
            {
                return NotFound();
            }

            var aspNetUser = await _ctx.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aspNetUser == null)
            {
                return NotFound();
            }

            return View(aspNetUser);
        }


        // POST: AdminUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_ctx.Users == null)
            {
                return Problem("Entity set 'AutoOglasContext.AspNetUsers'  is null.");
            }
            var aspNetUser = await _ctx.Users.FindAsync(id);
            if (aspNetUser != null)
            {
                _ctx.Users.Remove(aspNetUser);
            }

            await _ctx.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool AspNetUserExists(string id)
        {
            return (_ctx.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
