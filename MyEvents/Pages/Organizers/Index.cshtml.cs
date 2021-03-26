using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyEvents.Data;
using MyEvents.Models;

namespace MyEvents.Pages.Organizers
{
    public class IndexModel : PageModel
    {
        private readonly MyEventsContext _context;

        public IndexModel(MyEventsContext context)
        {
            _context = context;
        }

        public IList<Organizer> Organizer { get;set; }

        public async Task OnGetAsync()
        {
            Organizer = await _context.Organizers.ToListAsync();
        }
    }
}
