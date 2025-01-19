using FrenteDeLoja.Services;
using FrenteDeLoja.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrenteDeLoja.Infra
{
    public static class ApplicationServiceCollectionExtensions
    {
        [ExcludeFromCodeCoverage]
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            if(services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddScoped<ILoginServices, LoginServices>();
            services.AddScoped<IUsuarioServices, UsuarioServices>();

            return services;

        }
    }
}
