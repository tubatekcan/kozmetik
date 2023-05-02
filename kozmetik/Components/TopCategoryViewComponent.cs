using kozmetik.Data;
using kozmetik.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kozmetik.Components
{
    public class TopCategoryViewComponent : ViewComponent
    {
        private readonly cosmeticsDBContext _context;
        public TopCategoryViewComponent(cosmeticsDBContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            List<Category> categories = await _context.Categories.ToListAsync();

            return View("Default", categories);
        }
    }
}
