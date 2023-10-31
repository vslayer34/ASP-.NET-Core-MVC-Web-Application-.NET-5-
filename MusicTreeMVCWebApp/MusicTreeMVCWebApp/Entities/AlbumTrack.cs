using System.ComponentModel.DataAnnotations;

namespace MusicTreeMVCWebApp.Entities
{
    public class AlbumTrack
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 5)]
        public string Title { get; set; }
        public int AlbumId { get; set; }
        public int MediaTypId { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
