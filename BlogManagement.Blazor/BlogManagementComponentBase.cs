using BlogManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace BlogManagement;

public abstract class BlogManagementComponentBase : AbpComponentBase
{
    protected BlogManagementComponentBase()
    {
        LocalizationResource = typeof(BlogManagementResource);
    }
}
