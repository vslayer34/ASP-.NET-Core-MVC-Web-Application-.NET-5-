using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MusicTreeMVCWebApp.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicTreeMVCWebApp.Data
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(255)]
        public string FirstName { get; set; } = string.Empty;
        [StringLength(255)]
        public string LastName { get; set; } = string.Empty;
        [StringLength(255)] 
        public string Address1 { get; set; } = string.Empty;
        [StringLength(255)]
        public string Address2 { get; set; } = string.Empty;
        [StringLength(255)]
        public string PostCode { get; set; } = string.Empty;

        [ForeignKey("UserId")]
        public virtual ICollection<UserAlbum> UserAlbums { get; set; }
    }


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Album> Album { get; set; }
        public DbSet<AlbumTrack> AlbumTrack { get; set; }
        public DbSet<Content> Content { get; set; }
        public DbSet<MediaType> MediaType { get; set; }
        public DbSet<UserAlbum> UserAlbum { get; set; }
    }
}