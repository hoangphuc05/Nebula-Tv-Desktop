using Avalonia.Controls;
using AvaloniaNebula.ViewModels;
using Infrastructure;

namespace AvaloniaNebula.Views;

public partial class MainWindow : Window
{
    private CoreInfrastructure _coreInfrastructure;
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
        _coreInfrastructure = new CoreInfrastructure()
        {
            Token = "e0ea21438427fc6f91a4e41d09f04664db515ce6"
        };
        XMainContent.Content = new UserProfile(_coreInfrastructure);
    }
}