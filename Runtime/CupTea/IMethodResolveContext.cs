namespace CupTea
{
    public interface IMethodResolveContext
    {
        void AsTransient();
        void AsLazySingleton();
    }
}