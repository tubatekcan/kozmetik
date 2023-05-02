using kozmetik.Data;
using kozmetik.Models;
using kozmetik.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
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
            x.ProductList = await _context.Products.Include(a => a.Category)
                                    .Where(a => a.Category.CategoryName == kategori || kategori == null)
                                    .ToListAsync();
            x.CategoryList = await _context.Categories.Take(6).ToListAsync();  // uydurma modelimizi veri ile doldurduk. Bütün ürünleri doldurduk.
            return View(x); // sayfayı açarken modeldeki datalar ile açtık. şu anda tek data var. ileride artabilir.



        }

        public IActionResult Hakkimizda()
        {

            return View();

        }

        public async Task<IActionResult> UrunDetay(int? id)
        {
            if (id == null)
            {
                return View("SayfaBulunamadi");//linkte id yoksa client yönlendirme yapsın 
            }

            Product product = await _context.Products.FirstOrDefaultAsync(a => a.ProductID == id);
            return View(product);

        }
        public IActionResult SayfaBulunamadi()
        {
            return View();
        }
        public IActionResult SayfaHatali()
        {
            return View();
        }


        public IActionResult Iletisim()
        {
            return View();
        }
        public IActionResult SSS()
        {
            return View();
        }


        [Authorize(Roles = "NormalUser")]
        [HttpPost]
        public async Task<IActionResult> SepeteEkle([Bind("ProductID,Quantity")] Cart cart)
        {
            cart.RecordDate= DateTime.Now; 
            cart.UserrID= Convert.ToInt32(User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Sid)?.Value);
            //çerezden kullanıcı id çeken kod
            if (ModelState.IsValid)
            {
                await _context.Carts.AddAsync(cart);
                await _context.SaveChangesAsync();
                return Redirect("~/");
            }

            return Redirect("~/"); ;
        }



    }
}