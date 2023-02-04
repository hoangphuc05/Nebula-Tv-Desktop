using System.Threading.Tasks;
using Infrastructure;
using NebulaApi;
using NebulaApi.UsersApi;

namespace AvaloniaNebula.ViewModels;

public class AuthenticationUCViewModel
{
    public string? Token { get; set; }
    private CoreInfrastructure _coreInfrastructure;
    public AuthenticationUCViewModel()
    {
        _coreInfrastructure = CoreInfrastructure.Create();
    }

    public bool Login()
    {
        var nebula = new Nebula(Token);
        bool isLogin = Task.Run(async () => await nebula.CheckToken()).Result;
        if (isLogin)
        {
            _coreInfrastructure.NebulaObject = nebula;
        }

        return isLogin;
    }
}