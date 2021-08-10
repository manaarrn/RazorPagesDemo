using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages.Forms
{
    public class UploadFileModel : PageModel
    { 
        private IWebHostEnvironment _environment;
        public const string MessageKey = nameof(MessageKey);
        public UploadFileModel(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        [BindProperty]
        public IFormFile Upload { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (Upload == null || Upload.Length == 0)
            {
                TempData[MessageKey] = "Upload failed!";
                return RedirectToAction(Request.Path);
            }
            var file = Path.Combine(_environment.WebRootPath, "uploads", Upload.FileName);
            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await Upload.CopyToAsync(fileStream);
            }
            TempData[MessageKey] = "Upload successful!";
            return RedirectToAction(Request.Path);
        }
        public void OnGet()
        {
        }
    }
}
