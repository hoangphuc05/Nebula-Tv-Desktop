using Avalonia.Controls;

namespace Infrastructure.Interface;

public interface IWindowViewModel
{
    UserControl CurrentUc { get; set; }
}