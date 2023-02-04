using System.Text;
using NebulaApi.BaseApi;
using NebulaApi.UsersApi.Model;
using Newtonsoft.Json;

namespace NebulaApi.UsersApi;
public class LoginRequestObject
{
    [JsonProperty("email")]
    public string Email;
    [JsonProperty("password")]
    public string Password;
}
public class LoginApi : UnauthenticatedBaseApi<KeyModel>
{
    private const string BaseUrl = "https://users.api.nebula.app/api/v1/";

    private readonly string _username;
    private readonly string _password;
    public LoginApi(string username, string password, HttpClient? client = null) : base(BaseUrl, "auth/login/", client)
    {
        _username = username ?? throw  new ArgumentNullException(nameof(username));
        _password = password ?? throw new ArgumentNullException(nameof(password));
    }
    
    public async Task<KeyModel> Login()
    {
        var contentObject = new LoginRequestObject()
        {
            Email = _username,
            Password = _password
        };
        var contentPayload = JsonConvert.SerializeObject(contentObject);
        var httpContent = new StringContent(contentPayload, Encoding.UTF8, "application/json");
        var token = await base.PostAsync(httpContent);
        
        if (token == null)
        {
            throw new Exception("Authentication failed");
        }
        return token;
    }
}