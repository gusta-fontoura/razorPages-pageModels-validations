using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace razorPage_pageModel_vinculado.Pages
{
    public class CreateCountry : PageModel
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
            [Required]
            [StringLength(2, MinimumLength = 2, ErrorMessage = "A país precisa de pelo menos 2 caracteres.")]
            public string CountryCode { get; set; }

            public InputModel() {}

        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                this.CreatedCountry = new Country(Input.CountryName, Input.CountryCode);
            }
        }
    }
}
