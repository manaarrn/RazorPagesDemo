using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemo.Models;

namespace RazorPagesDemo.Pages.Forms
{
    public class StudentFormModel : PageModel
    {
        [BindProperty]
        public FormModel Student { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToPage("/Index", new { SFirstName = Student.FirstName});
        }
    }
}
