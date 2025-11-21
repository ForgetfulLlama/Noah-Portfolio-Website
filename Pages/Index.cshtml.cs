using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace Noah_Core_Portfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostDownloadFile()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "NoahCoreResume.pdf");
            Byte[] buffer = await System.IO.File.ReadAllBytesAsync(path);
            return File(buffer, "application/pdf");
        }
    }
}
