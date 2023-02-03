using Infrastructure.Interface;
using Autofac;
using NebulaApi.UsersApi.Model;

namespace Infrastructure;

public class CoreInfrastructure : ICoreInfrastructure
{
    public IContainer Container { get; private set; }
    public string Token { get; set; }
    
    public CoreInfrastructure()
    {
        // var builder = new ContainerBuilder();
        // builder.RegisterType<UserModel>().UsingConstructor()
    }
    
}