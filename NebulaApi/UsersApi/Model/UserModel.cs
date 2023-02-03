using Newtonsoft.Json;

namespace NebulaApi.UsersApi.Model;

public class UserModel
{
    [JsonProperty("pk")]
    public int Pk { get; set; }
    [JsonProperty("account_type")]
    public string AccountType { get; set; }
    [JsonProperty("created_at")]
    public string CreatedAt { get; set; }
    [JsonProperty("email")]
    public string Email { get; set; }
    [JsonProperty("email_verified")]
    public string EmailVerified { get; set; }
    [JsonProperty("has_curiositystream_subscription")]
    public bool HasCuriosityStreamSubscription { get; set; }
    [JsonProperty("is_subscribed")]
    public bool IsSubscribed { get; set; }
}