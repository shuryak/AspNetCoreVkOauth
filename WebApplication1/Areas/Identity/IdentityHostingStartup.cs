using Microsoft.AspNetCore.Hosting;
using WebApplication1.Areas.Identity;

[assembly: HostingStartup(typeof(IdentityHostingStartup))]

namespace WebApplication1.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => { });
        }
    }
}