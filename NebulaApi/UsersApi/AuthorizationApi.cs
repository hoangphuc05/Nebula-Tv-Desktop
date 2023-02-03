using NebulaApi.UsersApi.Model;

namespace NebulaApi.UsersApi;

public class AuthorizationApi : UsersApiBase<TokenModel>
{
    public AuthorizationApi(string token, HttpClient? client = null) : base(token, "authorization/", client)
    {
    }
}