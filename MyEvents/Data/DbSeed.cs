using MyEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEvents.Data
{
    public class DbSeed
    {
        public static void Seed(MyEventsContext context)
        {
            context.Database.EnsureCreated();

            if (context.Events.Any() ||
                context.Attendees.Any() ||
                context.Organizers.Any())
            {
                Console.WriteLine("Database already seeded.");
                return;
            }

            var attendee = new Attendee[]
            {
                new Attendee { Name = "TestUser", Email = "testuser@test.com", PhoneNumber = "0855063258" }
            };

            context.AddRange(attendee);
            context.SaveChanges();

            var organizers = new Organizer[]
            {
                new Organizer { Name = "JeMa Fest AB", Email = "jema@fest.com", PhoneNumber = "0798123445" }
            };
            context.AddRange(organizers);
            context.SaveChanges();

            var events = new Event[]
            {
                new Event 
                { 
                    Title = "Metallica",
                    Organizer = organizers[0],
                    Description = "Concert", 
                    Venue = "Globen", 
                    Address = "Storgatan 2", 
                    Date = new DateTime(20210301), 
                    TicketsAvailable = 20 
                },
                new Event 
                { 
                    Title = "Rock Around",
                    Organizer = organizers[0],
                    Description = "Festival", 
                    Venue = "Gröna fältet", 
                    Address = "Okänd", 
                    Date = new DateTime(20210914), 
                    TicketsAvailable = 200 
                }
            };

            context.AddRange(events);
            context.SaveChanges();
        }
    }
}
