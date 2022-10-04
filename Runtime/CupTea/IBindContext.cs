using System;

namespace CupTea
{
    public interface IBindContext<in TKey>
    {
        ITypeResolveContext FromType<TClass>() where TClass : TKey, new();
        IInstanceResolveContext FromInstance<TClass>(TClass instance) where TClass : TKey;
        IMethodResolveContext FromMethod(Func<TKey> provider);
    }
}