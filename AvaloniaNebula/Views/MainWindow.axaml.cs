using Avalonia.Controls;
using AvaloniaNebula.ViewModels;

namespace AvaloniaNebula.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}