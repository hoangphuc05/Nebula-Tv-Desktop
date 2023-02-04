using System;
using Avalonia.Controls;
using AvaloniaNebula.Views;
using Infrastructure;
using Infrastructure.Interface;
using ReactiveUI;
using AuthenticationWindow = AvaloniaNebula.NebulaUserControl.AuthenticationWindow;

namespace AvaloniaNebula.ViewModels;

public class MainWindowViewModel : ViewModelBase, IWindowViewModel
{
    private UserControl _currentUc;
    private CoreInfrastructure _coreInfrastructure;

    public UserControl CurrentUc
    {
        get => _currentUc;
        set => this.RaiseAndSetIfChanged(ref _currentUc, value);
    }

    public MainWindowViewModel()
    {
        _coreInfrastructure = CoreInfrastructure.Create();
        _coreInfrastructure.CurrentWindow = this;
        CurrentUc = new AuthenticationWindow();
    }
}