using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razorPage_pageModel_vinculado.Pages
{
    public class CreateCityModel : PageModel
    {
        public string CityName { get; set; }
        public void OnPost(string cityName) 
        {
            if (!string.IsNullOrEmpty(cityName))
            {
                this.CityName = cityName;
            }
        }

    }
}
