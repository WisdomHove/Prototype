using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Prototype.Data;
using Prototype.Models;

namespace Prototype.Pages.Suppliers
{
    public class IndexModel : PageModel
    {
        private readonly Prototype.Data.PrototypeContext _context;

        public IndexModel(Prototype.Data.PrototypeContext context)
        {
            _context = context;
        }

        public IList<Supplier> Supplier { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Names { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? SupplierName { get; set; }

        public async Task OnGetAsync()
        {
            var suppliers = from m in _context.Supplier
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                suppliers = suppliers.Where(s => s.Name.Contains(SearchString));
            }

            Supplier = await suppliers.ToListAsync();
        }
    }
}
