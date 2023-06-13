
using Volo.Abp.Domain.Entities;
namespace BlogManagement.Entities;

public class Post : BasicAggregateRoot<Guid>
{
    
    public string Title {get; set;}
    public string PostContent {get; set;}

    public bool IsPublished {get; set;}

    public bool IsDraft {get; set;}
    
    public Guid CreatedBy {get; set;}
}

