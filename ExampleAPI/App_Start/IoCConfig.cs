using Unity;

namespace ExampleAPI
{
    public class IoCConfig
    {
        public static void RegisterStartupRequirements(IUnityContainer container)
        {
            ExampleService.App_Start.IoCConfig.RegisterStartupRequirements(container);
        }
    }
}