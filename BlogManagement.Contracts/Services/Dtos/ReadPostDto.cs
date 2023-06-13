using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace BlogManagement.Dtos;

public class ReadPostDto
{
    [JsonPropertyName("id")]
    public Guid Id {get; set;}    
    [JsonPropertyName("title")]
    [Required]
    [MinLength(3)]
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
