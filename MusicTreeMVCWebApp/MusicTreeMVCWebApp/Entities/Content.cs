using System.ComponentModel.DataAnnotations;

namespace MusicTreeMVCWebApp.Entities
{
    public class Content
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 5)]
        public string Title { get; set; }

        public string HTMLContent { get; set; }
        public string VideoLink { get; set; }
        public string SpotifyLink { get; set; }

        public AlbumTrack AlbumTrack { get; set; }
    }
}
