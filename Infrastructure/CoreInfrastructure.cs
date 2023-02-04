using Infrastructure.Interface;
using Autofac;
using NebulaApi.UsersApi.Model;
using NebulaApi;

namespace Infrastructure;

public class CoreInfrastructure : ICoreInfrastructure
{
    public Nebula? NebulaObject { get; set; }

    public IWindowViewModel CurrentWindow;
    
    private static CoreInfrastructure? _currentInstance = null;
    public static CoreInfrastructure Create()
    {
        return _currentInstance ??= new CoreInfrastructure();
    }
    private CoreInfrastructure()
    {
        // var builder = new ContainerBuilder();
        // builder.RegisterType<UserModel>().UsingConstructor()
    }
    
}