using Newtonsoft.Json;

namespace NebulaApi.ContentApi.Model;

public class NebulaVideoModel
{
    [JsonProperty("title")]
    public String Title = "";

    [JsonProperty("channel_title")] public String ChannelTitle = "";

    [JsonProperty("slug")] public String Slug = "";

    [JsonProperty("share_url")] public String ShareUrl = "";

    [JsonProperty("duration")] public int Duration = 0;

    [JsonProperty("published_at")] public String PublishedAt = "";

}