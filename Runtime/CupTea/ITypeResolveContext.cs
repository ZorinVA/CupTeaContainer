namespace CupTea
{
    public interface ITypeResolveContext
    {
        void AsTransient();
        void AsLazySingleton();
    }
}