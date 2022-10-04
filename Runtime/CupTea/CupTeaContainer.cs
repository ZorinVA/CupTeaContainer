using CupTea.Core;
using ServiceLocator;

namespace CupTea
{
    public sealed class CupTeaContainer 
    {
        private readonly IServiceLocator _container;

        public CupTeaContainer(IServiceLocator container)
        {
            _container = container;
        }

        public IBindContext<TKey> Bind<TKey>()
        {
            return new BindContext<TKey>(_container);
        }

        public TKey Resolve<TKey>()
        {
            return _container.Resolve<TKey>();
        }
    }
}