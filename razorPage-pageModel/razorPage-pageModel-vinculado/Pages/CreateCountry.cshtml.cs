using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace razorPage_pageModel_vinculado.Pages
{
    public class CreateCountry : PageModel
    {
        //[BindProperty]
        //public InputModel Input { get; set; }

        [BindProperty]
        public List<InputModel> Inputs { get; set; }

  
        public Country CreatedCountry { get; set; }

        public List<Country> CreatedCountries { get; set; } = new List<Country>();
        public class Country
        {
            public String CountryName { get; set; }
            public String CountryCode { get; set; }

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


        public void OnGet()
        {
            Inputs = new List<InputModel>();
            for (int i = 0; i < 5; i++)
            {
                Inputs.Add(new InputModel());
            }
        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
    

                this.CreatedCountries = new List<Country>();

                foreach (var item in Inputs) 
                {
                    
                    if (!string.IsNullOrEmpty(item.CountryName))
                    {
                        
                        var countryCreated = new Country(item.CountryName, item.CountryCode);
                        this.CreatedCountries.Add(countryCreated);
                    }
                }
            }
        }
    }
}
