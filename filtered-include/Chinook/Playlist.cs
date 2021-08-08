﻿using System.Collections.Generic;

#nullable disable

namespace Chinook
{
    public partial class Playlist
    {
        public Playlist()
        {
            PlaylistTracks = new HashSet<PlaylistTrack>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PlaylistTrack> PlaylistTracks { get; set; }
    }
}