using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Prototype.Models;

namespace Prototype.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Prototype.Data.PrototypeContext _context;

        public IndexModel(Prototype.Data.PrototypeContext context)
        {
            _context = context;
        }

        public IList<Supplier> Supplier { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Supplier != null)
            {
                Supplier = await _context.Supplier.ToListAsync();
            }
        }
    }
}