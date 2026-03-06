using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razorPage_pageModel_vinculado.Pages
{
    public class CityDetailsModel : PageModel
    {
        public string CityName { get; set; }
        public void OnGet(string cityName)
        {
            CityName = cityName;
        }
    }
}
