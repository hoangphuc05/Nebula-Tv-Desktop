namespace NebulaApi.Interface;

public interface IAuthenticatedBaseApi<T>
{
    string Url { get; }
    Task<T?> GetResponse();
}