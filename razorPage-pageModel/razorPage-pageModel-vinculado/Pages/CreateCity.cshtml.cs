using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace razorPage_pageModel_vinculado.Pages
{
    public class CreateCityModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; } = new();

        public string CityNameResult { get; set; }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                this.CityNameResult = Input.CityName;
            }
        }

        public class InputModel
        {
            [Required(ErrorMessage = "O preenchimento do nome é obrigatório.")]
            [MinLength(3, ErrorMessage = "A cidade precisa de pelo menos 3 caracteres.")]
            public string CityName { get; set; }
        }
    }
}