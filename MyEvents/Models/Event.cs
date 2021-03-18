using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvents.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int OrganizerID { get; set; }
        public string Description { get; set; }
        public string Venue { get; set; }
        public string Adress { get; set; }
        public DateTime Date { get; set; }
        public int TicketsAvailable { get; set; }
        public Organizer Organizer { get; set; }
        public virtual List<Attendee> Attendees { get; set; }
    }
}
