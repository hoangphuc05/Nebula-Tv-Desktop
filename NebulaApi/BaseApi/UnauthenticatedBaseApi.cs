namespace NebulaApi.BaseApi;

public class UnauthenticatedBaseApi<T>
{
    private readonly string _path;
    private readonly string _baseUrl;
    private readonly HttpClient _client;
    
    public UnauthenticatedBaseApi(string baseUrl, string path, HttpClient? client = null)
    {
        _path = path;
        _baseUrl = baseUrl;
        _client = client ?? new HttpClient();
        _client.BaseAddress = new Uri(baseUrl);
    }
    
    public virtual async Task<T?> PostAsync(HttpContent? content = null)
    {
        T? response = default(T);
        HttpResponseMessage responseMessage = await _client.PostAsync(_path, content);
        
        if (responseMessage.IsSuccessStatusCode)
        {
            response = await responseMessage.Content.ReadAsAsync<T>();
        }
        return response;
    }
}