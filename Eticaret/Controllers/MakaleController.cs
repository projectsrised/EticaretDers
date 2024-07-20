using Eticaret.BAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.WebUI.Controllers
{
    public class MakaleController : Controller
    {
        private readonly IMakaleService makaleService;
        private readonly IKategoriService kategoriService;  
        public MakaleController(IMakaleService _makaleService,IKategoriService _kategoriService)
        {
              makaleService = _makaleService;   
              kategoriService = _kategoriService;   
        }
        public IActionResult Index()
        {
           
            return View(makaleService.GetAll()!.AsQueryable());
        }
        public IActionResult Create() {
            
            
            return View(kategoriService.GetAll()!.AsQueryable());
        }

        [HttpPost]
        public IActionResult Create(int KategoriId, string title, string aciklama, string yazar, string icerik)
        {
            return View(kategoriService.GetAll()!.AsQueryable());
        }
    }
}
