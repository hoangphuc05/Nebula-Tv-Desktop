using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using AvaloniaNebula.NebulaUserControl.Interface;
using AvaloniaNebula.ViewModels;

namespace AvaloniaNebula.NebulaUserControl;

public partial class AuthenticationWindow : UserControl
{
    public AuthenticationWindow()
    {
        InitializeComponent();
        DataContext = new AuthenticationUCViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void XLoginButton_OnClick(object? sender, RoutedEventArgs e)
    {
        if (DataContext is AuthenticationUCViewModel viewModel)
        {
            viewModel.Login();

        }
    }

}