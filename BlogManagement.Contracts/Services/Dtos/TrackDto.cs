using System.Text.Json.Serialization;

namespace BlogManagement.Services.Dtos
{
    public class TrackDto
    {
        [JsonPropertyName("total_drafts")]
        public int TotalDrafts { get; set; }
        [JsonPropertyName("total_published")]
        public int TotalPublished { get; set; }
        [JsonPropertyName("total_comments")]
        public int TotalComments { get; set; }
    }
}