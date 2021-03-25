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
    public class MyEventsModel : PageModel
    {
        private readonly MyEvents.Data.MyEventsContext _context;

        public MyEventsModel(MyEvents.Data.MyEventsContext context)
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
