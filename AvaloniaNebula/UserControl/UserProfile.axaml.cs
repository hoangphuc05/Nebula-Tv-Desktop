using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaNebula.ViewModels;
using Infrastructure.Interface;

namespace AvaloniaNebula;

public partial class UserProfile : UserControl
{
    public UserProfile()
    {
        InitializeComponent();
    }
    public UserProfile(ICoreInfrastructure coreInfrastructure)
    {
        InitializeComponent();
        DataContext = new UserProfileViewModel(coreInfrastructure);
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}