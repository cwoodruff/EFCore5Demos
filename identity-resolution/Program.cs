using System;
using System.Collections.Generic;
using System.Linq;
using Chinook;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace identity_resolution
{
    public class Program
    {
        static void Main()
        {
            using var db = new ChinookContext();
            
            var albums = db.Albums
                .AsNoTrackingWithIdentityResolution()
                .ToList();
            
            foreach (var album in albums)
            {
                Console.WriteLine($"Found Album: {album.Title}");
            }
            
        }
    }
}