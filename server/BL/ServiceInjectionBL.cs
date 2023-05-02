
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class ServiceInjectionBL
    {
        public static void InjectionsBL(this IServiceCollection service)
        {
            service.AddSingleton<IDriverServiceBL, DriverServiceBL>();
            service.AddSingleton<IDriveServiceBL, DriveServiceBL>();
            service.AddSingleton<IClientServiceBL, ClientServiceBL>();
            service.AddSingleton<IPackageSrviceBL, PackageSrviceBL>();
            service.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            service.InjectionsDal();
        }
    }
}
