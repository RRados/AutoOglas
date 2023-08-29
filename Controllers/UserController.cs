using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAppOglas.Controllers
{
    public class UserController : Controller
    {
        private UserManager<IdentityUser> userManager;

        public async Task<IActionResult> IndexAsync(string id)
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
    }
}
