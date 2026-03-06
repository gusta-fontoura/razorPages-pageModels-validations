using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razorPage_pageModel_vinculado.Pages
{
    public class CityListModel : PageModel
    {
        public List<string> Cities { get; set; } = new();

        public void OnGet()
        {
            Cities = new List<string> { "Rio", "São Paulo", "Brasília" };
        }
    }
}
