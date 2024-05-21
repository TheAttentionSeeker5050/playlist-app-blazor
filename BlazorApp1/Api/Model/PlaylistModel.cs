namespace BlazorApp1.Api.Model
{
    public class PlaylistModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }


        // Return a dummy list of playlists
        public static List<PlaylistModel> GetPlaylists()
        {
            return new List<PlaylistModel>
            {
                new PlaylistModel
                {
                    Id = 1,
                    Name = "Playlist 1",
                    Description = "Description 1",
                    Image = "https://via.placeholder.com/150"
                },
                new PlaylistModel
                {
                    Id = 2,
                    Name = "Playlist 2",
                    Description = "Description 2",
                    Image = "https://via.placeholder.com/150"
                },
                new PlaylistModel
                {
                    Id = 3,
                    Name = "Playlist 3",
                    Description = "Description 3",
                    Image = "https://via.placeholder.com/150"
                },
                new PlaylistModel
                {
                    Id = 4,
                    Name = "Playlist 4",
                    Description = "Description 4",
                    Image = "https://via.placeholder.com/150"
                },
                new PlaylistModel
                {
                    Id = 5,
                    Name = "Playlist 5",
                    Description = "Description 5",
                    Image = "https://via.placeholder.com/150"
                },
                new PlaylistModel
                {
                    Id = 6,
                    Name = "Playlist 6",
                    Description = "Description 6",
                    Image = "https://via.placeholder.com/150"
                },
                new PlaylistModel
                {
                    Id = 7,
                    Name = "Playlist 7",
                    Description = "Description 7",
                    Image = "https://via.placeholder.com/150"
                },
                new PlaylistModel
                {
                    Id = 8,
                    Name = "Playlist 8",
                    Description = "Description 8",
                    Image = "https://via.placeholder.com/150"
                },
                new PlaylistModel
                {
                    Id = 9,
                    Name = "Playlist 9",
                    Description = "Description 9",
                    Image = "https://via.placeholder.com/150"
                },
                new PlaylistModel
                {
                    Id = 10,
                    Name = "Playlist 10",
                    Description = "Description 10",
                    Image = "https://via.placeholder.com/150"
                }
            };
        }
    }

}
