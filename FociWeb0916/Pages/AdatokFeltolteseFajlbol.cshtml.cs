using FociWeb0916.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FociWeb0916.Pages
{
    public class AdatokFeltolteseFajlbolModel : PageModel
    {
        private readonly IWebHostEnvironment? _env;
        private readonly FociDBContext _context;
        public AdatokFeltolteseFajlbolModel(IWebHostEnvironment env, FociDBContext context)
        {
            _env = env;
            _context = context;
        }
        [BindProperty]
        public IFormFile? Feltoltes {  get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(Feltoltes == null || Feltoltes.Length == 0)
            {
                ModelState.AddModelError("Feltoltes", "Adj meg egy állományt!");
                return Page();
            }

            var UploadDirPath = Path.Combine(_env.ContentRootPath, "Uploads");
            var UploadFilePath = Path.Combine(UploadDirPath, Feltoltes.FileName);
            using (var stream = new FileStream(UploadFilePath, FileMode.Create))
            {
               await Feltoltes.CopyToAsync(stream);
            }
            StreamReader sr = new StreamReader(UploadFilePath);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                var elemek = line.Split();
                Meccs ujMeccs = new Meccs();
                ujMeccs.Fordulo = int.Parse(elemek[0]);
                ujMeccs.Hazaiveg = int.Parse(elemek[1]);
                ujMeccs.Vendegveg = int.Parse(elemek[2]);
                ujMeccs.HazaiFel = int.Parse(elemek[3]);
                ujMeccs.VendegFel = int.Parse(elemek[4]);
                ujMeccs.HazaiCsapat = elemek[5];
                ujMeccs.VendegCsapat = elemek[6];
                _context.Meccs.Add(ujMeccs);
            }





            sr.Close();
            _context.SaveChanges();
            System.IO.File.Delete(UploadFilePath);
            return Page();
        }
    }
}
