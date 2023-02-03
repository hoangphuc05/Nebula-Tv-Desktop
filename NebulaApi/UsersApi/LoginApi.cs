using NebulaApi.UsersApi.Model;

namespace NebulaApi.UsersApi;

public class LoginApi : UsersApiBase<KeyModel>
{
    public LoginApi(string token, HttpClient? client = null) : base(token, "login/", client)
    {
    }
}