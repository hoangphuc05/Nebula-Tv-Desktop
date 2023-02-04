using Infrastructure;
using ReactiveUI;

namespace AvaloniaNebula.ViewModels;

public class FeatureViewModel : ReactiveObject
{
    private string _rawContent = "Loading?";

    public string RawContent
    {
        get => _rawContent;
        set => this.RaiseAndSetIfChanged(ref _rawContent, value);
    }

    private CoreInfrastructure _coreInfrastructure;
    
    public FeatureViewModel()
    {
        _coreInfrastructure = CoreInfrastructure.Create();
        RawContent = _coreInfrastructure.NebulaObject?.Bearer ?? "";
    }
}