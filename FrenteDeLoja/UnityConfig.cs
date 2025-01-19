using AutoMapper;
using FrenteDeLoja.Infra.AutoMapper;
using FrenteDeLoja.Infra.Contexto;
using FrenteDeLoja.Repositories;
using FrenteDeLoja.Repositories.Interfaces;
using FrenteDeLoja.Services;
using FrenteDeLoja.Services.Interfaces;
using FrenteDeLoja.View.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace FrenteDeLoja
{
    public class UnityConfig
    {
        public static IUnityContainer RegisterComponents()
        {
            var container = new UnityContainer();

            // Regsitrar os forms
            container.RegisterType<MDContext>();
            container.RegisterType<frmLogin>();

            // Registrar as dependências no Unity Container
            container.RegisterType<ILoginServices, LoginServices>();
            container.RegisterType<IUsuarioServices, UsuarioServices>();

            // Registrar outros repositorios
            container.RegisterType<IUsuarioRepositorio, UsuarioRepositorio>();

            // Registrar o perfil do AutoMapper e criar uma instância de IMapper
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());  // Adiciona o perfil de mapeamento
            });

            var mapper = mapperConfig.CreateMapper();
            container.RegisterInstance<IMapper>(mapper);

            return container;
        }
    }
}
