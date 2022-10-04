using ServiceLocator;

namespace CupTea.Core
{
    internal readonly struct InstanceResolveContext<TKey> : IInstanceResolveContext
    {
        private readonly IServiceLocator _container;
        private readonly TKey _instance;

        public InstanceResolveContext(IServiceLocator container, TKey instance)
        {
            _container = container;
            _instance = instance;
        }

        public void AsSingleton()
        {
            _container.RegisterSingleton(_instance);
        }
    }
}