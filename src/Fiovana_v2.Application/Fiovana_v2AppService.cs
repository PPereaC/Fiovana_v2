using Fiovana_v2.Localization;
using Volo.Abp.Application.Services;

namespace Fiovana_v2;

/* Inherit your application services from this class.
 */
public abstract class Fiovana_v2AppService : ApplicationService
{
    protected Fiovana_v2AppService()
    {
        LocalizationResource = typeof(Fiovana_v2Resource);
    }
}
