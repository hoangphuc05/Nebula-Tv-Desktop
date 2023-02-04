using System.Security.Authentication;
using NebulaApi.UsersApi;
using NebulaApi.UsersApi.Model;
using System.IdentityModel.Tokens.Jwt;
using NebulaApi.Utilities;

namespace NebulaApi;

public class Nebula
{
    private UserModel? _user;

    private string _bearer = "";

    public string Bearer
    {
        get
        {
            if (!JwtHelper.IsValid(_bearer))
            {
                _bearer = Task.Run(async () => await JwtHelper.RefreshToken(Token)).Result?.Token ?? "";
            }

            return _bearer;
        }
    }

    public UserModel User
    {
        get
        {
            return _user ??= Task.Run(async () => await new UserInfo(Token).PostAsync()).Result ??
                             throw new AuthenticationException();
        }
    }

    public string Token { get; private set; }
    
    public Nebula(string username, string password)
    {
        var token = Task.Run(async () => await new LoginApi(username, password).Login()).Result;
        Token = token.Key;
    }

    public Nebula(string token)
    {
        Token = token;
    }

    public async Task<bool> CheckToken()
    {
        var token = await new UserInfo(Token).GetResponseAsync();
        return token != null;
    }
    
}