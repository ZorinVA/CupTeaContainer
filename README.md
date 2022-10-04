# CupTeaContainer

## Usage
### Initialization
```csharp
public class ApplicationContext : MonoBehaviour
{
    private static CupTeaContainer _container;

    private void Awake()
    {
        _container = new CupTeaContainer(new StaticServiceLocator());
    }
	
    //Use Awake or Start
    private void Start()
    {
        _container.Bind<ISomeInterface>().FromInstance(new SomeClass()).AsSingleton();
    }
    
    public static T Resolve<T>()
    {
        return _container.Resolve<T>();
    }
}
```

### Resolve
```csharp
public class ResolveExample : MonoBehaviour
{
    private ISomeInterface _someInterface;

    private void Awake()
    {
        _someInterface = ApplicationContext.Resolve<ISomeInterface>();
    }
}
```

### Instance binding
```csharp
_container.Bind<ISomeInterface>().FromInstance(new SomeClass()).AsSingleton();
```

### Type binding
```csharp
_container.Bind<ISomeInterface>().FromType<SomeClass>().AsTransient();
_container.Bind<ISomeInterface>().FromType<SomeClass>().AsLazySingleton();
```
	
### Method binding
```csharp
_container.Bind<ISomeInterface>().FromMethod(() => new SomeClass()).AsTransient();
_container.Bind<ISomeInterface>().FromMethod(() => new SomeClass()).AsLazySingleton();
```

### MonoBehaviour binding
```csharp
_container.Bind<ISomeInterface>().FromInstance(instanceReference).AsSingleton();
_container.Bind<ISomeInterface>().FromMethod(() => Instantiate(prefabReference)).AsTransient();
_container.Bind<ISomeInterface>().FromMethod(() => Instantiate(prefabReference)).AsLazySingleton();
```