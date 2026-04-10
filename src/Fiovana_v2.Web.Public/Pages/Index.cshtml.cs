using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Fiovana_v2.Web.Public.Pages;

public class IndexModel : Fiovana_v2PublicPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
