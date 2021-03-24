using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvents.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Venue { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public int TicketsAvailable { get; set; }
        public Organizer Organizer { get; set; }
        public ICollection<Attendee> Attendees { get; set; }
    }
}
