using ExampleRepo.Repositories;
using Unity;
using Unity.Lifetime;


namespace ExampleRepo.App_Start
{
    public class IoCConfig
    {
        public static void RegisterStartupRequirements(IUnityContainer container)
        {
            container.RegisterType<IExampleRepository, Repositories.ExampleRepo>(new ContainerControlledLifetimeManager());
        }
    }
}