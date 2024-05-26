using System;
using System.Collections.Generic;

namespace BlazorApp1.Model
{
    public class PlaylistItem
    {
        public int Id { get; set; }
        public int PlaylistId { get; set; }
        public int SongId { get; set; }

        // The creation and update date of the playlist item
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;

        // Add the reference to the song and playlist model
        public SongModel SongModel { get; set; } = new SongModel();
        public PlaylistModel playlistModel { get; set; } = new PlaylistModel();

        
    }
}
