using NebulaApi.BaseApi;
using NebulaApi.UsersApi.Model;

namespace NebulaApi.UsersApi;

public abstract class UsersApiBase<T> : AuthenticatedBaseApi<T>
{
    private const string BaseUrl = "https://users.api.nebula.app/api/v1/";
    protected UsersApiBase(string token, string path, HttpClient? client = null)
        : base(token, BaseUrl, path, client)
    {
    }
}