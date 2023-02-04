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
        _coreInfrastructure = CoreInfrastructure.Create();
        XMainContent.Content = new AuthenticationWindow();
    }
}