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

        public DbSet<Event> Event { get; set; }
    }
}
