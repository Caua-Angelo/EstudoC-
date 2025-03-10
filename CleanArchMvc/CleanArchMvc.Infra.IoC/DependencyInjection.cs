using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Infra.IoC
{
    public static class  DependencyInjection
    {
        public static IserviceCollection AddInfraestructure(this IServiceCollection,IConfiguration configuration)
    }
}
