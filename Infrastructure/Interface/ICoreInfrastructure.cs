using NebulaApi;

namespace Infrastructure.Interface;

public interface ICoreInfrastructure
{
    Nebula? NebulaObject { get; }
}