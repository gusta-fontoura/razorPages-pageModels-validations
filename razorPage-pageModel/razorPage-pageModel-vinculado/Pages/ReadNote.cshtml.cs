using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razorPage_pageModel_vinculado.Pages
{
    public class ReadNoteModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;

        public ReadNoteModel(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public List<string> FileNames { get; set; } = new();

        public void OnGet()
        {
            var folderPath = Path.Combine(_environment.WebRootPath, "files");

            if (Directory.Exists(folderPath))
            {
                // Pega apenas os nomes dos arquivos do diretório
                FileNames = Directory.GetFiles(folderPath)
                                     .Select(Path.GetFileName)
                                     .ToList();
            }
        }
    }
}
