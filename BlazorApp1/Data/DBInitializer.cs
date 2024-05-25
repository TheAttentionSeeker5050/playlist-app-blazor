using System;
using System.Linq;
using BlazorApp1.Model;

namespace BlazorApp1.Data
{
    public static class DBInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any playlists
            if (context.Playlists.Any())
            {
                Console.WriteLine("DB has alreadt been seeded");
                return; // DB has been seeded
            }

            // Add a collection of playlists
            var playlists = new PlaylistModel[]
            {
                new PlaylistModel
                {
                    Name = "Playlist 1",
                    Description = "Description 1",
                    Image = "https://via.placeholder.com/150"
                },
                new PlaylistModel
                {
                    Name = "Playlist 2",
                    Description = "Description 2",
                    Image = "https://via.placeholder.com/150"
                },
                new PlaylistModel
                {
                    Name = "Playlist 3",
                    Description = "Description 3",
                    Image = "https://via.placeholder.com/150"
                },
                new PlaylistModel
                {
                    Name = "Playlist 4",
                    Description = "Description 4",
                    Image = "https://via.placeholder.com/150"
                },
                new PlaylistModel
                {
                    Name = "Playlist 5",
                    Description = "Description 5",
                    Image = "https://via.placeholder.com/150"
                },
                new PlaylistModel
                {
                    Name = "Playlist 6",
                    Description = "Description 6",
                    Image = "https://via.placeholder.com/150"
                }
            };

            foreach (PlaylistModel playlist in playlists)
            {
                context.Playlists.Add(playlist);
            }

            context.SaveChanges();

            if (context.Songs.Any())
            {
                Console.WriteLine("DB has alreadt been seeded");
                return; // DB has been seeded
            }

            // Add a collection of songs
            var songs = new SongModel[]
            {
                new SongModel
                {
                    Name = "Song 1",
                    Artist = "Artist 1",
                    Image = "https://via.placeholder.com/150"
                },
                new SongModel
                {
                    Name = "Song 2",
                    Artist = "Artist 2",
                    Image = "https://via.placeholder.com/150"
                },
                new SongModel
                {
                    Name = "Song 3",
                    Artist = "Artist 3",
                    Image = "https://via.placeholder.com/150"
                },
                new SongModel
                {
                    Name = "Song 4",
                    Artist = "Artist 4",
                    Image = "https://via.placeholder.com/150"
                },
                new SongModel
                {
                    Name = "Song 5",
                    Artist = "Artist 5",
                    Image = "https://via.placeholder.com/150"
                },
                new SongModel
                {
                    Name = "Song 6",
                    Artist = "Artist 6",
                    Image = "https://via.placeholder.com/150"
                },
                new SongModel
                {
                    Name = "Song 7",
                    Artist = "Artist 7",
                    Image = "https://via.placeholder.com/150"
                },
                new SongModel
                {
                    Name = "Song 8",
                    Artist = "Artist 8",
                    Image = "https://via.placeholder.com/150"
                },
                new SongModel
                {
                    Name = "Song 9",
                    Artist = "Artist 9",
                    Image = "https://via.placeholder.com/150"
                },
                new SongModel
                {
                    Name = "Song 10",
                    Artist = "Artist 10",
                    Image = "https://via.placeholder.com/150"
                }
            };

            foreach (SongModel song in songs)
            {
                context.Songs.Add(song);
            }

            context.SaveChanges();

            if (context.PlaylistItems.Any())
            {
                Console.WriteLine("DB has alreadt been seeded");
                return; // DB has been seeded
            }

            // Add a collection of playlist items
            var playlistItems = new PlaylistItem[]
            {
                new PlaylistItem
                {
                    PlaylistId = 1,
                    SongId = 1,
                    Created = DateTime.Now,
                    Updated = DateTime.Now
                },
                new PlaylistItem
                {
                    PlaylistId = 1,
                    SongId = 2,
                    Created = DateTime.Now,
                    Updated = DateTime.Now
                },
                new PlaylistItem
                {
                    PlaylistId = 2,
                    SongId = 3,
                    Created = DateTime.Now,
                    Updated = DateTime.Now
                },
                new PlaylistItem
                {
                    PlaylistId = 2,
                    SongId = 4,
                    Created = DateTime.Now,
                    Updated = DateTime.Now
                },
                new PlaylistItem
                {
                    PlaylistId = 3,
                    SongId = 5,
                    Created = DateTime.Now,
                    Updated = DateTime.Now
                },
                new PlaylistItem
                {
                    PlaylistId = 3,
                    SongId = 6,
                    Created = DateTime.Now,
                    Updated = DateTime.Now
                },
                new PlaylistItem
                {
                    PlaylistId = 4,
                    SongId = 7,
                    Created = DateTime.Now,
                    Updated = DateTime.Now
                },
                new PlaylistItem
                {
                    PlaylistId = 4,
                    SongId = 8,
                    Created = DateTime.Now,
                    Updated = DateTime.Now
                },
                new PlaylistItem
                {
                    PlaylistId = 5,
                    SongId = 9,
                    Created = DateTime.Now,
                    Updated = DateTime.Now
                },
                new PlaylistItem
                {
                    PlaylistId = 5,
                    SongId = 10,
                    Created = DateTime.Now,
                    Updated = DateTime.Now
                }
            };

            foreach (PlaylistItem playlistItem in playlistItems)
            {
                context.PlaylistItems.Add(playlistItem);
            }

            context.SaveChanges();

        }


    }
}
