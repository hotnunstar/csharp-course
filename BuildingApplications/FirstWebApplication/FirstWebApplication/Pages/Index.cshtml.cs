using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApplication.Pages
{
    public class IndexModel : PageModel
    {
        public bool hasData = false;
        public string userName = "";
        public string email = "";
        public string password = "";


        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost() 
        { 
            hasData = true;
            userName = Request.Form["username"];
            email = Request.Form["email"];
            password = Request.Form["password"];
        }
    }
}
