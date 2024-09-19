using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FociWeb0916.Models;

namespace FociWeb0916.Pages
{
    public class MerkozesekDetailsModel : PageModel
    {
        private readonly FociWeb0916.Models.FociDBContext _context;

        public MerkozesekDetailsModel(FociWeb0916.Models.FociDBContext context)
        {
            _context = context;
        }

        public Meccs Meccs { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meccs = await _context.Meccs.FirstOrDefaultAsync(m => m.Id == id);
            if (meccs == null)
            {
                return NotFound();
            }
            else
            {
                Meccs = meccs;
            }
            return Page();
        }
    }
}
