using Microsoft.AspNetCore.Hosting;
using VkOauthExample.Areas.Identity;

[assembly: HostingStartup(typeof(IdentityHostingStartup))]

namespace VkOauthExample.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => { });
        }
    }
}