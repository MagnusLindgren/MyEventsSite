using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyEvents.Data;
using MyEvents.Models;

namespace MyEvents.Pages.Attendees
{
    public class MyEventsModel : PageModel
    {
        private readonly MyEventsContext _context;

        public MyEventsModel(MyEventsContext context)
        {
            _context = context;
        }

        public Attendee Attendee{ get; set; }

        public async Task OnGetAsync()
        {
            Attendee = await _context.Attendees.Where(a => a.AttendeeId == 1)
                .Include(e => e.Events)
                .FirstOrDefaultAsync();
        }
    }
}
