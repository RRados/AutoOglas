using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppOglas.Data;

namespace WebAppOglas.Models
{
    public class Admin : IdentityUser
    {
        protected WebAppOglasContext _context;

        public Admin(WebAppOglasContext context)
        {
            _context = context;
        }

        public Admin()
        {
                
        }

        public void GetUsers()
        {
            //_context.Users.FirstOrDefault();
        }


        //public virtual async Task<IdentityUser> UpdateAsync(IdentityUser user)
        //{
        //    if (user == null) 
        //        return null;

        //    user = new IdentityUser();

        //    string errorMsg = null;
            
        //    try
        //    {
        //        user = await _context.Set<IdentityUser>().FindAsync(user.Id);
        //        if (user == null)
        //        {
        //            errorMsg = "Can't find item to update";
        //            return user;
        //        }
        //        _context.Entry(user).CurrentValues.SetValues(user);

        //        var result = await _context.SaveChangesAsync();
        //        if (result == 0) 
        //            errorMsg = "Can't saved item";
        //    }
        //    catch (Exception ex)
        //    {

        //        errorMsg = ex.Message;
        //        return user;
        //    }


        //    return user;
        //}


    }
}
