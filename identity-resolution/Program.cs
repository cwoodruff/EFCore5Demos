using System;
using System.Linq;
using Chinook;
using Microsoft.EntityFrameworkCore;

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