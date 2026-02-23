using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razorPage_pageModel_vinculado.Pages
{
    public class CreateCityModel : PageModel
    {
        [BindProperty]
        public string CityName { get; set; }
        public void OnPost() 
        {
        }

    }
}
