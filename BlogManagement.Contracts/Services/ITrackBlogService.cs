
using BlogManagement.Services.Dtos;
using Volo.Abp.Application.Services;

namespace BlogManagement.Services
{
    public interface ITrackBlogService: IApplicationService
    {
        public Task<TrackDto> GetCountAsync();
    }
}