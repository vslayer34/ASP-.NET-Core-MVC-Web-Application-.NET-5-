using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

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
    }


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}