using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace Zealand_Zoo_1FProjekt1semester2024.Pages.Events
{
    public class BasePageModelModel : PageModel
    {
        public string Name => HttpContext.Session.GetString("Name");

        public bool IsAuthenticated => !string.IsNullOrEmpty(Name);

        public void CheckLogin()
        {
            if (!IsAuthenticated)
            {
                Response.Redirect("/Events/Login");
            }
        }
    }
}
