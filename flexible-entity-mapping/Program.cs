using System;
using System.Collections.Generic;
using System.Linq;
using Chinook;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace flexible_entity_mapping
{
    public class Program
    {
        static void Main()
        {
            using var db = new ChinookContext();
            
            var albums = db.Albums
                .ToList();
            
            foreach (var album in albums)
            {
                Console.WriteLine($"Found Album: {album.Title} -- Artists: {album.Name}");
            }
            
        }
    }
}