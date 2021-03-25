using System;
using System.Linq;
using Chinook;

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