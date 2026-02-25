using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razorPage_pageModel_vinculado.Pages
{
    public class CreatyCountry : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }

  
        public Country CreatedCountry { get; set; }
        public class Country
        {
            public String CountryName;
            public String CountryCode;

            public Country(String countryName, String countryCode)
            {
                CountryName = countryName;
                CountryCode = countryCode;
            }
        }

        public class InputModel
        {
            public string CountryName { get; set; }
            public string CountryCode { get; set; }

            public InputModel() {}

        }

        public void OnGet()
        {
        }
    }
}
