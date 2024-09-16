using FociWeb0916.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FociWeb0916.Pages
{
    public class UjMeccsFelveteleModel : PageModel
    {
        [BindProperty]
        public Meccs UjMeccs {  get; set; }

        public List<Meccs> MeccsekListaja { get; set; }

        private readonly FociDBContext _db;
        public UjMeccsFelveteleModel(FociDBContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            MeccsekListaja = _db.Meccs.ToList();
        }

        public IActionResult OnPost() 
        {
            _db.Meccs.Add(UjMeccs);
            _db.SaveChanges();
            return Page();
        
        }


    }
}
