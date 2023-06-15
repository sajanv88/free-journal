using BlogManagement.Dtos;
using BlogManagement.Services.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace BlogManagement.Services;
public interface IBlogService: IApplicationService
{
    Task<ReadPostDto> CreatePostAsync(CreatePostDto post);
    Task<ReadPostDto> GetPostAsync(Guid Id);
    Task<PagedResultDto<ReadPostDto>> GetPostsAsync(GetPaginatedBlog input);
    Task<ReadPostDto> UpdatePostAsync(CreatePostDto post, Guid Id);
    Task DeletePostAsync(Guid Id);
}
