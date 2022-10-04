using ServiceLocator;

namespace CupTea.Core
{
    internal readonly struct TypeResolveContext<TKey, TClass> : ITypeResolveContext where TClass : TKey, new()
    {
        private readonly IServiceLocator _container;

        public TypeResolveContext(IServiceLocator container)
        {
            _container = container;
        }
        
        public void AsTransient()
        {
            _container.RegisterTransient<TKey>(() => new TClass());
        }

        public void AsLazySingleton()
        {
            _container.RegisterLazySingleton<TKey>(() => new TClass());
        }
    }
}