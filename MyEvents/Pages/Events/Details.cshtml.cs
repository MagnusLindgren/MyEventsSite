using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyEvents.Data;
using MyEvents.Models;

namespace MyEvents.Pages.Events
{
    public class DetailsModel : PageModel
    {
        private readonly MyEventsContext _context;

        public DetailsModel(MyEventsContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }

        [BindProperty]
        public Event AddEvent { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Events
                .Include(e => e.Organizer).FirstOrDefaultAsync(m => m.EventId == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Kalla på attendee, inkludera events (ICollection)
            var attendee = await _context.Attendees
                .Where(a => a.AttendeeId == 1)
                .Include(e => e.Events)
                .FirstOrDefaultAsync();

            // Vilket event vi pratar om. Event id från url
            var join = await _context.Events
                .Where(e => e.EventId == id)
                .FirstOrDefaultAsync();

            attendee.Events.Add(join);

            await _context.SaveChangesAsync();

            return RedirectToPage("../Attendees/MyEvents");
        }
    }
}