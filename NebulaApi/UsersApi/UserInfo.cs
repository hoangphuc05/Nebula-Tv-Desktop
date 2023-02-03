using NebulaApi.UsersApi.Model;

namespace NebulaApi.UsersApi;

public class UserInfo : UsersApiBase<UserModel>
{
    public UserInfo(string token, HttpClient? client = null) : base(token, "auth/user/", client)
    {
    }
}