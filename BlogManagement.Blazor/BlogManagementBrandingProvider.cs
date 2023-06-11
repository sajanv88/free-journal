using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BlogManagement;

[Dependency(ReplaceServices = true)]
public class BlogManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BlogManagement";
}
