using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(IdentitySample.Startup))]

namespace IdentitySample
{
   
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}
