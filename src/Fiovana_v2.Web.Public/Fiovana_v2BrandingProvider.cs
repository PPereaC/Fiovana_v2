using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using Fiovana_v2.Localization;

namespace Fiovana_v2.Web.Public;

[Dependency(ReplaceServices = true)]
public class Fiovana_v2BrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<Fiovana_v2Resource> _localizer;

    public Fiovana_v2BrandingProvider(IStringLocalizer<Fiovana_v2Resource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
