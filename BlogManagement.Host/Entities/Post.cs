using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities;
namespace BlogManagement.Entities;

public class Post : BasicAggregateRoot<Guid>
{
    [Required]
    [MinLength(3)]
    public string Title {get; set;} = string.Empty;
    public string PostContent {get; set;} = string.Empty;
    public Guid CreatedBy {get; set;}
}

