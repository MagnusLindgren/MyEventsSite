using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyEvents.Data;
using MyEvents.Models;

namespace MyEvents.Pages.Attendees
{
    public class IndexModel : PageModel
    {
        private readonly MyEventsContext _context;

        public IndexModel(MyEventsContext context)
        {
            _context = context;
        }

        public IList<Attendee> Attendee { get;set; }

        public async Task OnGetAsync()
        {
            Attendee = await _context.Attendees.ToListAsync();
        }
    }
}
