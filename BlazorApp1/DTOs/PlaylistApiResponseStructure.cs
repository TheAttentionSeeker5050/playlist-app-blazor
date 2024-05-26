namespace BlazorApp1.DTOs
{
    public class PlaylistDetailsDto
    {
        public PlaylistMetadataDto PlaylistMetadata { get; set; }
        public List<SongDto> PlaylistSongs { get; set; }
    }

    public class PlaylistMetadataDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }

    public class SongDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Image { get; set; }
    }
}
