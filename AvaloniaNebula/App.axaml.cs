using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaNebula.ViewModels;
using AvaloniaNebula.Views;

namespace AvaloniaNebula;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel(),
            };
            // desktop.MainWindow = new AuthenticationWindow()
            // {
            //     DataContext = new MainWindowViewModel(),
            // };
        }

        base.OnFrameworkInitializationCompleted();
    }
}