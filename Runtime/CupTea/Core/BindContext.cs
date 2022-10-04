using System;
using ServiceLocator;

namespace CupTea.Core
{
    internal readonly struct BindContext<TKey> : IBindContext<TKey>
    {
        private readonly IServiceLocator _container;

        internal BindContext(IServiceLocator container)
        {
            _container = container;
        }

        public ITypeResolveContext FromType<TClass>() where TClass : TKey, new()
        {
            return new TypeResolveContext<TKey, TClass>(_container);
        }

        public IInstanceResolveContext FromInstance<TClass>(TClass instance) where TClass : TKey
        {
            return new InstanceResolveContext<TKey>(_container, instance);
        }
        
        public IMethodResolveContext FromMethod(Func<TKey> provider)
        {
            return new MethodResolveContext<TKey>(_container, provider);
        }
    }
}