using Fiovana_v2.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Fiovana_v2.Web.Public.Pages;

/* Inherit your Page Model classes from this class.
 */
public abstract class Fiovana_v2PublicPageModel : AbpPageModel
{
    protected Fiovana_v2PublicPageModel()
    {
        LocalizationResourceType = typeof(Fiovana_v2Resource);
    }
}
