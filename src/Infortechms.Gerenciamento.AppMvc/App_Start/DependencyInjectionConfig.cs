using Infortechms.Gerenciamento.Business.Core.Notificacoes;
using Infortechms.Gerenciamento.Business.Core.Services;
using Infortechms.Gerenciamento.Business.Models.ConsumoCombustivel;
using Infortechms.Gerenciamento.infra.Data.Context;
using Infortechms.Gerenciamento.infra.Data.Repository;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System.Reflection;
using System.Web.Mvc;

namespace Infortechms.Gerenciamento.AppMvc.App_Start
{
    public class DependencyInjectionConfig
    {
        public static void RegisterDIcontainer()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        private static void InitializeContainer(Container container)
        {
            container.Register<ProjetoSalarioSContext>(Lifestyle.Scoped);

            container.Register<IConsumoCombustivelRepository, ConsumoCombustivelRepository>(Lifestyle.Scoped);

            container.Register<IConsumoCombustivelService, ConsumoCombustivelService>(Lifestyle.Scoped);

            container.Register<INotificador, Notificador>(Lifestyle.Scoped);

            container.RegisterSingleton(()=> AutoMapperConfig.GetMapperConfiguration().CreateMapper(container.GetInstance));
        }
    }
}