using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaNebula.ViewModels;

namespace AvaloniaNebula.NebulaUserControl;

public partial class FeatureUC : UserControl
{
    public FeatureUC()
    {
        InitializeComponent();
        DataContext = new FeatureViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}