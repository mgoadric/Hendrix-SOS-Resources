using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SOSResources.Models;

namespace SOSResources.Pages.Departments
{
    public class IndexModel : PageModel
    {
        private readonly SOSResources.Data.SchoolContext _context;

        public IndexModel(SOSResources.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Department> Department { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Departments != null)
            {
                Department = await _context.Departments.ToListAsync();
            }
        }
    }
}
