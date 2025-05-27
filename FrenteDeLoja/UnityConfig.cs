using AutoMapper;
using FrenteDeLoja.Infra.AutoMapper;
using FrenteDeLoja.Infra.Contexto;
using FrenteDeLoja.Infra.Repositories;
using FrenteDeLoja.Infra.Repositories.Interfaces;
using FrenteDeLoja.Services;
using FrenteDeLoja.Services.Interfaces;
using FrenteDeLoja.View;
using FrenteDeLoja.View.Login;
using Unity;

namespace FrenteDeLoja
{
    public class UnityConfig
    {
        public static IUnityContainer RegisterComponents()
        {
            var container = new UnityContainer();

            // Registrar os forms
            container.RegisterType<MDContext>();
            container.RegisterType<frmLogin>();
            container.RegisterType<frmTrocaSenha>();
            container.RegisterType<frmEsqueciSenha>();
            container.RegisterType<frmLoading>();
            container.RegisterType<frmTelaPrincipal>();

            // Registrar as dependências no Unity Container
            container.RegisterType<IUsuarioServices, UsuarioServices>();
            container.RegisterType<IEmailService, EmailService>();

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
