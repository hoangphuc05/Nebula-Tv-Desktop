using Newtonsoft.Json;

namespace NebulaApi.UsersApi.Model;

public class TokenModel
{
    [JsonProperty("token")] public string Token = "";
}