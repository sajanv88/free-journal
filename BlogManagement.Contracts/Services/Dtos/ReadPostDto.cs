using System.Text.Json.Serialization;
namespace BlogManagement.Dtos;

public class ReadPostDto
{
    [JsonPropertyName("id")]
    public Guid Id {get; set;}    
    [JsonPropertyName("title")]
    public string Title {get; set;} = string.Empty;
    [JsonPropertyName("post_content")]
    public string PostContent {get; set;} = string.Empty;

    [JsonPropertyName("created_by")]
    public Guid CreatedBy {get; set;}
}
