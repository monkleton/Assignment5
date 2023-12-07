﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Assignment5.Data;
using System;
using System.Linq;


namespace Assignment5.Models
{
    public class SeedData
    {
        
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Assignment5Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Assignment5Context>>()))
            {
                if (context.Song.Any())
                {
                    return;  
                }
                context.Artist.AddRange(
                    new Artist
                    {
                        Name = "Cotton Eye Joe",
                        Genre = "Country"
                    },
                    new Artist
                    {
                        Name = "Darude",
                        Genre = "EDM"
                    },
                    new Artist
                    {
                        Name = "Weird Al",
                        Genre = "Rap"
                    },
                    new Artist
                    {
                        Name = "Psy",
                        Genre = "Pop"
                    },
                    new Artist
                    {
                        Name = "Micheal Jackson",
                        Genre = "Pop"
                    },
                    new Artist
                    {
                        Name = "Country Boy",
                        Genre = "Country"
                    },
                    new Artist
                    {
                        Name = "Popstar",
                        Genre = "Pop"
                    },
                    new Artist
                    {
                        Name = "BeepBoop",
                        Genre = "EDM"
                    },
                    new Artist
                    {
                        Name = "Gorillaz",
                        Genre = "Rock"
                    },
                    new Artist
                    {
                        Name = "Alice In Chains",
                        Genre = "Rock"
                    }

                );
              
                context.SaveChanges();

                context.Song.AddRange(
                    new Song { Name = "Country Anthem", Price = 10.99m, Year = 2008, Artist = context.Artist.First(a => a.Name == "Cotton Eye Joe")},
                    new Song { Name = "Country Jammers", Price = 12.99m, Year = 2001, Artist = context.Artist.First(a => a.Name == "Cotton Eye Joe") },
                    new Song { Name = "I Love Me Some Country", Price = 11.99m, Year = 2010, Artist = context.Artist.First(a => a.Name == "Cotton Eye Joe") },
                    new Song { Name = "Sandstorm", Price = 1.99m, Year = 2012, Artist = context.Artist.First(a => a.Name == "Darude") },
                    new Song { Name = "Tornado", Price = 1.50m, Year = 2002, Artist = context.Artist.First(a => a.Name == "Darude") },
                    new Song { Name = "Blizzard", Price = 1.89m, Year = 2040, Artist = context.Artist.First(a => a.Name == "Darude") },
                    new Song { Name = "Yoda", Price = 1.79m, Year = 2050, Artist = context.Artist.First(a => a.Name == "Weird Al") },
                    new Song { Name = "Fat", Price = 2.50m, Year = 2001, Artist = context.Artist.First(a => a.Name == "Weird Al") },
                    new Song { Name = "Gangnam Style", Price = 1.99m, Year = 2020, Artist = context.Artist.First(a => a.Name == "Psy") },
                    new Song { Name = "Gangnam Style 2: Electric Boogaloo", Price = 1.99m, Year = 2004, Artist = context.Artist.First(a => a.Name == "Psy") },
                    new Song { Name = "Gangnam Style Deluxe Edition", Price = 100.99m, Year = 2005, Artist = context.Artist.First(a => a.Name == "Psy") },
                    new Song { Name = "Bad", Price = 1.99m, Year = 2009, Artist = context.Artist.First(a => a.Name == "Micheal Jackson") },
                    new Song { Name = "Beat It", Price = 1.99m, Year = 2005, Artist = context.Artist.First(a => a.Name == "Micheal Jackson") },
                    new Song { Name = "Billie Jean", Price = 1.99m, Year = 2040, Artist = context.Artist.First(a => a.Name == "Micheal Jackson") },
                    new Song { Name = "Yee HAWW", Price = 5.99m, Year = 2003, Artist = context.Artist.First(a => a.Name == "Country Boy") },
                    new Song { Name = "TractorTime", Price = 2.99m, Year = 2005, Artist = context.Artist.First(a => a.Name == "Country Boy") },
                    new Song { Name = "PopTime", Price = 3.99m, Year = 2060, Artist = context.Artist.First(a => a.Name == "Popstar") },
                    new Song { Name = "Popping It up", Price = 1.99m, Year = 2007, Artist = context.Artist.First(a => a.Name == "Popstar") },
                    new Song { Name = "Beeeep", Price = 1.99m, Year = 2002, Artist = context.Artist.First(a => a.Name == "BeepBoop") },
                    new Song { Name = "Im A SUPER ROBOT", Price = 2.99m, Year = 2035, Artist = context.Artist.First(a => a.Name == "BeepBoop") },
                    new Song { Name = "Feel Good Inc.", Price = 7.99m, Year = 2030, Artist = context.Artist.First(a => a.Name == "Gorillaz") },
                    new Song { Name = "Plastic Beach", Price = 3.99m, Year = 2065, Artist = context.Artist.First(a => a.Name == "Gorillaz") },
                    new Song { Name = "I Stay Away", Price = 4.99m, Year = 2002, Artist = context.Artist.First(a => a.Name == "Alice In Chains") },
                    new Song { Name = "Died", Price = 5.99m, Year = 2002, Artist = context.Artist.First(a => a.Name == "Alice In Chains") },
                    new Song { Name = "Dirt", Price = 1.99m, Year = 2004 , Artist = context.Artist.First(a => a.Name == "Alice In Chains") }
                    

                );
                context.SaveChanges();
            }
        }
    }


}
