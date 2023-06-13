using System.Text.Json.Serialization;
namespace BlogManagement.Services.Dtos;

public class CreatePostDto
{
    [JsonPropertyName("title")]
    public string Title {get; set;} = string.Empty;
    [JsonPropertyName("post_content")]
    public string PostContent {get; set;} = string.Empty;

    [JsonPropertyName("created_by")]
    public Guid CreatedBy {get; set;}

    [JsonPropertyName("is_published")]
    public bool IsPublished {get; set;}

    [JsonPropertyName("is_draft")]
    public bool IsDraft {get; set;}
}
