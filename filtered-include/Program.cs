using System;
using System.Collections.Generic;
using System.Linq;
using Chinook;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace filtered_include
{
    public class Program
    {
        static void Main()
        {
            using var db = new ChinookContext();
            
            var artists = db.Artists
                .Include(e => e.Albums.Where(a => a.Title.Contains("the")))
                .AsSplitQuery()
                .ToList();
            
            foreach (var artist in artists)
            {
                Console.WriteLine($"Found Album: {artist.Name} - {artist.Albums.Count}");
            }
            
        }
    }
}