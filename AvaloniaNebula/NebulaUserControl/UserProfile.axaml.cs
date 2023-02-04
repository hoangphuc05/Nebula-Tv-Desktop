using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaNebula.NebulaUserControl.Interface;
using AvaloniaNebula.ViewModels;
using Infrastructure;
using Infrastructure.Interface;

namespace AvaloniaNebula.NebulaUserControl;

public partial class UserProfile : UserControl, INebulaUC
{
    public UserProfile()
    {
        InitializeComponent();
        DataContext = new UserProfileViewModel(CoreInfrastructure.Create());
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public Action<UserControl> SetCurrentUc { get; set; }
}