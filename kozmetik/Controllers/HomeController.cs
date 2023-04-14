using kozmetik.Data;
using kozmetik.Models;
using kozmetik.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace kozmetik.Controllers
{
    public class HomeController : Controller
    {

        private readonly cosmeticsDBContext _context;

        public HomeController(cosmeticsDBContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index(string kategori)
        {
            HomeViewModel x = new HomeViewModel();



            // uydurma modelimizi veri ile doldurduk. Bütün ürünleri doldurduk.
            x.ProductList = await   _context.Product.Include(a=>a.Category)
                                    .Where(a=>a.Category.CategoryName==kategori || kategori==null)
                                    .ToListAsync(); 
            x.CategoryList = await _context.Category.Take(6).ToListAsync();  // uydurma modelimizi veri ile doldurduk. Bütün ürünleri doldurduk.
            return View(x); // sayfayı açarken modeldeki datalar ile açtık. şu anda tek data var. ileride artabilir.



        }

        public IActionResult Hakkimizda()
        {

            return View();

        }

        public IActionResult UrunDetay(int? id)
        {
            if (id == null)
            {
                return View("SayfaBulunamadi");//linkte id yoksa client yönlendirme yapsın 
            }
            //varsa aşağıdan devam etsin, kod burdan devam ederse kullanıcı id girmişitr.



            return View();

        }
        public IActionResult SayfaBulunamadi()
        {
            return View();
        }
        public IActionResult SayfaHatali()
        {
            return View();
        }



    }
}