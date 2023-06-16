using System.Linq.Dynamic.Core;
using BlogManagement.Dtos;
using BlogManagement.Entities;
using BlogManagement.Services.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace BlogManagement.Services
{
    public class TrackBlogBlogService: ApplicationService, ITrackBlogService
    {
        private readonly IRepository<Post, Guid> _postRepository;
    
        public TrackBlogBlogService(IRepository<Post, Guid> postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<TrackDto> GetCountAsync()
        {
            var query = await _postRepository.GetQueryableAsync();
            var totalDrafts = query.Where(p => p.IsDraft).ToList().Count;
            var totalPublished = query.Where(p => p.IsPublished).ToList().Count;

            return new TrackDto() {
                TotalDrafts = totalDrafts,
                TotalPublished = totalPublished,
                TotalComments = 0
            };
        }
    }
}