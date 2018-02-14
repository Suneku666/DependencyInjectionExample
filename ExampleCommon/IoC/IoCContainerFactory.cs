using Unity;

namespace ExampleCommon.IoC
{
    public static class IoCContainerFactory
    {
        static IUnityContainer container;

        public static IUnityContainer GetContainer ()
        {
            if(container != null)
            {
                return container;
            }

            container = new UnityContainer();

            return container;
        }
    }
}