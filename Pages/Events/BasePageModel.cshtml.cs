using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace Zealand_Zoo_1FProjekt1semester2024.Pages.Events
{
    public class BasePageModelModel : PageModel
    {
        // This property checks if an admin name is present in the session
        public bool IsAdminAuthenticated => !string.IsNullOrEmpty(HttpContext.Session.GetString("AdminName"));

        public void CheckAdminLogin()
        {
            // Redirect to login if not an admin
            if (!IsAdminAuthenticated)
            {
                Response.Redirect("/Events/Login");
            }
        }
    }
}
