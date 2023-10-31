using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicTreeMVCWebApp.Entities
{
    public class Album
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 255)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string AlbumArtPath {  get; set; }

        [ForeignKey("AlbumId")]
        public ICollection<AlbumTrack> AlbumTracks { get; set; }

        [ForeignKey("AlbumId")]
        public virtual ICollection<UserAlbum> UserAlbums { get; set; }
    }
}
