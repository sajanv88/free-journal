using BlogManagement.Entities;
using Volo.Abp.Domain.Repositories;

namespace BlogManagement.Repository
{
    public interface IBlogRepository: IRepository<Post, Guid>
    {
        public Task<List<Post>> GetListAsync(
            string sorting = null,
            int maxResultCount = int.MaxValue,
            int skipCount = 0,
            string filter = null,
            bool includeDetails = false,
            CancellationToken cancellationToken = default);
    }
}
