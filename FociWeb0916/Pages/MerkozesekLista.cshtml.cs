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
    public class MerkozesekListaModel : PageModel
    {
        private readonly FociWeb0916.Models.FociDBContext _context;

        public MerkozesekListaModel(FociWeb0916.Models.FociDBContext context)
        {
            _context = context;
        }

        public IList<Meccs> Meccs { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Meccs = await _context.Meccs.ToListAsync();
        }
    }
}
