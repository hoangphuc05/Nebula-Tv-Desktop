using System.Threading.Tasks;
using Infrastructure.Interface;
using NebulaApi;
using NebulaApi.UsersApi;
using NebulaApi.UsersApi.Model;
using ReactiveUI;

namespace AvaloniaNebula.ViewModels;

public class UserProfileViewModel : ReactiveObject
{
    private ICoreInfrastructure _coreInfrastructure;

    private UserModel? _user;

    public UserModel? User
    {
        get => _user; 
        private set => this.RaiseAndSetIfChanged(ref _user, value);
    } 

    public UserProfileViewModel()
    {
        
    }
    public UserProfileViewModel(ICoreInfrastructure coreInfrastructure)
    {
        _coreInfrastructure = coreInfrastructure;
        // Task.Run(async () =>
        // {
        //     User = await (new UserInfo(coreInfrastructure.Token)).GetResponseAsync();
        // });
    }
}