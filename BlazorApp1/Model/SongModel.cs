using System;
using System.Collections.Generic;
using BlazorApp1.Model;

namespace BlazorApp1.Model
{
    public class SongModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Image { get; set; }

        // Add a collection of playlist items to the playlist model
        public ICollection<PlaylistItem> PlaylistItems { get; set; }

        

        // Return a dummy list of songs
        public static List<SongModel> GetSongs()
        {
            return new List<SongModel>
            {
                new SongModel
                {
                    Id = 1,
                    Name = "Song 1",
                    Artist = "Artist 1",
                    Image = "https://via.placeholder.com/150"
                },
                new SongModel
                {
                    Id = 2,
                    Name = "Song 2",
                    Artist = "Artist 2",
                    Image = "https://via.placeholder.com/150"
                },
                new SongModel
                {
                    Id = 3,
                    Name = "Song 3",
                    Artist = "Artist 3",
                    Image = "https://via.placeholder.com/150"
                },
                new SongModel
                {
                    Id = 4,
                    Name = "Song 4",
                    Artist = "Artist 4",
                    Image = "https://via.placeholder.com/150"
                },
                new SongModel
                {
                    Id = 5,
                    Name = "Song 5",
                    Artist = "Artist 5",
                    Image = "https://via.placeholder.com/150"
                },
                new SongModel
                {
                    Id = 6,
                    Name = "Song 6",
                    Artist = "Artist 6",
                    Image = "https://via.placeholder.com/150"
                },
                new SongModel
                {
                    Id = 7,
                    Name = "Song 7",
                    Artist = "Artist 7",
                    Image = "https://via.placeholder.com/150"
                },
                new SongModel
                {
                    Id = 8,
                    Name = "Song 8",
                    Artist = "Artist 8",
                    Image = "https://via.placeholder.com/150"
                },
                new SongModel
                {
                    Id = 9,
                    Name = "Song 9",
                    Artist = "Artist 9",
                    Image = "https://via.placeholder.com/150"
                },
                new SongModel
                {
                    Id = 10,
                    Name = "Song 10",
                    Artist = "Artist 10",
                    Image = "https://via.placeholder.com/150"
                }
            };
        }
    }
}
