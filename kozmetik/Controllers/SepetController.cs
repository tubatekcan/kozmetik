using kozmetik.Data;
using kozmetik.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kozmetik.Controllers
{
    [Authorize(Roles = "NormalUser")]
    public class SepetController : Controller
    {


        private readonly cosmeticsDBContext _context;

        public SepetController(cosmeticsDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            int sidd = Convert.ToInt32(User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Sid)?.Value);
            List<Cart> myCartItems = await _context.Carts.Include(a => a.Product).Where(a => a.UserrID == sidd).ToListAsync();
            return View(myCartItems);
        }

        public async Task<IActionResult> SatinAl()
        {
            int sidd = Convert.ToInt32(User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Sid)?.Value);
            List<Cart> myBuyingItems = await _context.Carts.Include(a => a.Product).Where(a => a.UserrID == sidd).ToListAsync();
            return View(myBuyingItems);
        }
    }
}
