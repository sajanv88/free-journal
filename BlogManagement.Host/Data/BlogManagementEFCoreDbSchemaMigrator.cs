using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace BlogManagement.Data;

public class BlogManagementEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public BlogManagementEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BlogManagementDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BlogManagementDbContext>()
            .Database
            .MigrateAsync();
    }
}
