using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razorPage_pageModel_vinculado.Pages
{
    public class SaveNoteModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;

        public SaveNoteModel(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [BindProperty]
        public string Content { get; set; }
        public string Message { get; set; }

        public async Task OnPostAsync()
        {
            if (string.IsNullOrEmpty(Content)) return;

            var folderPath = Path.Combine(_environment.WebRootPath, "files");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var fileName = $"note-{DateTime.Now:yyyyMMddHHmmss}.txt";
            var filePath = Path.Combine(folderPath, fileName);

            await System.IO.File.WriteAllTextAsync(filePath, Content);

            Message = $"Arquivo '{fileName}' salvo com sucesso!";
        }
    }
}
