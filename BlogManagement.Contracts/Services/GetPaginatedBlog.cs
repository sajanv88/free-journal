using Volo.Abp.Application.Dtos;

namespace BlogManagement.Services
{
    public class GetPaginatedBlog: PagedAndSortedResultRequestDto
    {
        public string? Filter { get; set; }
    }
}