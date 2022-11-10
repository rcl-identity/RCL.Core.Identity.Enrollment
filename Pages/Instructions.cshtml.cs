using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace RCL.Core.Identity.Enrollment.Pages
{
    [AllowAnonymous]
    public class InstructionsModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
