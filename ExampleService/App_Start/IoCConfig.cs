using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;
using Unity.Lifetime;

namespace ExampleService.App_Start
{
    public class IoCConfig
    {
        public static void RegisterStartupRequirements(IUnityContainer container)
        {
            container.RegisterType<IExampleService, ExampleService>(new ContainerControlledLifetimeManager());

            ExampleRepo.App_Start.IoCConfig.RegisterStartupRequirements(container);
        }
    }
}