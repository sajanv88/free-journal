using BlogManagement.Dtos;
using BlogManagement.Services.Dtos;
using Volo.Abp.Application.Services;

namespace BlogManagement.Services;
public interface IBlogService: IApplicationService
{
    Task<ReadPostDto> CreatePostAsync(CreatePostDto post);
    Task<ReadPostDto> GetPostAsync(Guid Id);
    Task<List<ReadPostDto>> GetPostsAsync();
    Task<ReadPostDto> UpdatePostAsync(CreatePostDto post, Guid Id);
    Task DeletePostAsync(Guid Id);
}
