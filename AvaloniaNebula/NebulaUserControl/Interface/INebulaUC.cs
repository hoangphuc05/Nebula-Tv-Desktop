using System;
using Avalonia.Controls;

namespace AvaloniaNebula.NebulaUserControl.Interface;

public interface INebulaUC
{
    Action<UserControl> SetCurrentUc { set; }
}