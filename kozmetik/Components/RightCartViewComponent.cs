using kozmetik.Data;
using kozmetik.Models;
using kozmetik.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kozmetik.Components
{
    public class RightCartViewComponent : ViewComponent
    {
        private readonly cosmeticsDBContext _context;
        public RightCartViewComponent(cosmeticsDBContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int? sid)
        {
            CartViewModel x = new CartViewModel();
            x.cartss = new List<Cart>();
            x.sidd= 0;
            if (sid!=0)
            {
                x.cartss= await _context.Carts.Include(a => a.Product).Where(a => a.UserrID == sid).ToListAsync();
                x.sidd = sid;
            }
            
            return View("Default", x);
        }
    }
}
