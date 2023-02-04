using System.Threading.Tasks;
using AvaloniaNebula.NebulaUserControl;
using Infrastructure;
using Infrastructure.Interface;
using NebulaApi;
using NebulaApi.UsersApi;

namespace AvaloniaNebula.ViewModels;

public class AuthenticationUCViewModel
{
    public string Token { get; set; }
    private CoreInfrastructure _coreInfrastructure;
    public AuthenticationUCViewModel()
    {
        _coreInfrastructure = CoreInfrastructure.Create();
        Token = "";
    }

    public bool Login()
    {
        var nebula = new Nebula(Token);
        bool isLogin = Task.Run(async () => await nebula.CheckToken()).Result;
        if (isLogin)
        {
            _coreInfrastructure.NebulaObject = nebula;
            _coreInfrastructure.CurrentWindow.CurrentUc = new FeatureUC();
        }

        return isLogin;
    }
}