using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FociWeb0916.Models;

namespace FociWeb0916.Pages
{
    public class UjMerkozesFelveteleModel : PageModel
    {
        private readonly FociWeb0916.Models.FociDBContext _context;

        public UjMerkozesFelveteleModel(FociWeb0916.Models.FociDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Meccs Meccs { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Meccs.Add(Meccs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
