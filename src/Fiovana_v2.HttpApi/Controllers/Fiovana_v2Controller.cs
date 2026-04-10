using Fiovana_v2.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Fiovana_v2.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Fiovana_v2Controller : AbpControllerBase
{
    protected Fiovana_v2Controller()
    {
        LocalizationResource = typeof(Fiovana_v2Resource);
    }
}
