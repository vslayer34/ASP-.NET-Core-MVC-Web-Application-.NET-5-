using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicTreeMVCWebApp.Entities
{
    public class MediaType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 6)]
        public string Title { get; set; }

        [Required]
        public string AlbumArtPath { get; set; }

        [ForeignKey("MediaTypId")]
        public ICollection<AlbumTrack> AlbumTracks { get; set; }
    }
}
