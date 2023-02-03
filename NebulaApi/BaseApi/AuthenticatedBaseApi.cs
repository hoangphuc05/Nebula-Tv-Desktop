using System.Net.Http.Headers;
using NebulaApi.Interface;

namespace NebulaApi.BaseApi;

public abstract class AuthenticatedBaseApi<T> : IAuthenticatedBaseApi<T>
{
    private string _token;
    private readonly string _path;
    private readonly string _baseUrl;
    private readonly HttpClient _client;

    public string Url => _path;
    protected AuthenticatedBaseApi(string token, string baseUrl, string path, HttpClient? client = null)
    {
        _token = token;
        _path = path;
        _baseUrl = baseUrl;
        _client = client ?? new HttpClient();
        _client.BaseAddress = new Uri(baseUrl);
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", token);
    }

    public virtual async Task<T?> GetResponse()
    {
        T? user = default(T);
        HttpResponseMessage responseMessage = await _client.GetAsync(_path);
        if (responseMessage.IsSuccessStatusCode)
        {
            user = await responseMessage.Content.ReadAsAsync<T>();
        }
        return user;
    }
}