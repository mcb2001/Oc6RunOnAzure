using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace Oc6RunOnAzure
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseFileServer();
        }
    }
}
