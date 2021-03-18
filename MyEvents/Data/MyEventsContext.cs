using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyEvents.Models;

namespace MyEvents.Data
{
    public class MyEventsContext : DbContext
    {
        public MyEventsContext (DbContextOptions<MyEventsContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Organizer> Organizers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Event>().ToTable("Event");
            modelbuilder.Entity<Attendee>().ToTable("Attendee");
            modelbuilder.Entity<Organizer>().ToTable("Organizer");
        }        
    }
}
