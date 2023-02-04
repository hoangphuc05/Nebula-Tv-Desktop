
using System.IdentityModel.Tokens.Jwt;
using NebulaApi.UsersApi;
using NebulaApi.UsersApi.Model;

namespace NebulaApi.Utilities;

public static class JwtHelper
{
    public static bool IsValid(string token)
    {
        JwtSecurityToken jwtSecurityToken;
        try
        {
            jwtSecurityToken = new JwtSecurityToken(token);
        }
        catch (Exception)
        {
            return false;
        }
    
        return jwtSecurityToken.ValidTo > DateTime.UtcNow;
    }

    public static async Task<TokenModel?> RefreshToken(string token)
    {
        return await new AuthorizationApi(token).PostAsync();
    }
}