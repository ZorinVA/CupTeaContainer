using System;
using ServiceLocator;

namespace CupTea.Core
{
    internal readonly struct MethodResolveContext<TKey> : IMethodResolveContext
    {
        private readonly IServiceLocator _container;
        private readonly Func<TKey> _provider;

        public MethodResolveContext(IServiceLocator container, Func<TKey> provider)
        {
            _container = container;
            _provider = provider;
        }

        public void AsTransient()
        {
            _container.RegisterTransient(_provider);
        }

        public void AsLazySingleton()
        {
            _container.RegisterLazySingleton(_provider);
        }
    }
}