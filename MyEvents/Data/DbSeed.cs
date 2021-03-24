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
                new Organizer { Name = "JeMa IT AB", Email = "jema@it.com", PhoneNumber = "0798123445" },
                new Organizer { Name = "Music Gruop", Email = "music@group.com", PhoneNumber = "0700654987" },
                new Organizer { Name = "Sports & Stuff", Email = "sports@hotmail.com", PhoneNumber = "0715972345" },
                new Organizer { Name = "Event Maker", Email = "eventmaker@gmail.com", PhoneNumber = "0713465798" }
            };
            context.AddRange(organizers);
            context.SaveChanges();

            var events = new Event[]
            {
                new Event 
                { 
                    Title = "Metallica",
                    Organizer = organizers[1],
                    Description = "Concert", 
                    Venue = "Globen", 
                    Address = "Storgatan 2", 
                    Date =  DateTime.Parse("2021-03-14"), 
                    TicketsAvailable = 30245 
                },

                new Event 
                { 
                    Title = "Rock Around",
                    Organizer = organizers[1],
                    Description = "Festival", 
                    Venue = "Gröna fältet", 
                    Address = "Okänd", 
                    Date = DateTime.Parse("2021-09-14"), 
                    TicketsAvailable = 20231 
                },

                new Event
                {
                    Title = "Lär dig koda rätt",
                    Organizer = organizers[0],
                    Description = "Lär dig koda på rätt sätt. Vi går igenom objekt orienterad programmering.",
                    Venue = "Tältets konferansrum",
                    Address = "Mittigatan 2",
                    Date = DateTime.Parse("2021-07-29"),
                    TicketsAvailable = 200
                },

                new Event
                {
                    Title = "AIK - Hammarby",
                    Organizer = organizers[2],
                    Description = "Fotbolls match",
                    Venue = "Stora Plan",
                    Address = "Långgatan 123",
                    Date = DateTime.Parse("2021-07-30"),
                    TicketsAvailable = 1200
                }
            };

            context.AddRange(events);
            context.SaveChanges();
        }
    }
}
