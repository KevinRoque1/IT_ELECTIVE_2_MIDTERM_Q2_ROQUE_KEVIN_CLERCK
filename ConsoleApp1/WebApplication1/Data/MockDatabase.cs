using PlaylistApp.Models.Entities;
using WebApplication1.Models.Entities;

namespace WebApplication1.Data
{
    public static class MockDatabase
    {
        public static List<Playlist> Playlists { get; set; } = new()
        {
            new Playlist
            {
                Title = "Favs Spider-Man",
                CreatorName = "System",
                Videos = new List<VideoItem>
                {
                   new VideoItem { YouTubeUrl = "https://www.youtube.com/watch?v=GNtIvGrqAZE", TrackNote = "Hey Violet - Hoodie" },
                    new VideoItem { YouTubeUrl = "https://www.youtube.com/watch?v=UrEif84sgu0", TrackNote = "Rihanna - Kiss It Better" }
                }
            }
        };
    }
}