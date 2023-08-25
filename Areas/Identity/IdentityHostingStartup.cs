using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(WebAppOglas.Areas.Identity.IdentityHostingStartup))]
namespace WebAppOglas.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {       

        public void Configure(IWebHostBuilder builder)
        {
           
        }
    }
}


 
   