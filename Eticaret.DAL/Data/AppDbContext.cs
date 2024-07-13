using Eticaret.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;




namespace Eticaret.DAL.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
         
        }


        public virtual DbSet<Etiket> Etikets { get; set; }
        public virtual DbSet<Kategori> Kategoris { get; set; }
        public virtual DbSet<Makale> Makales { get; set; }
        public virtual DbSet<Sayfalar> Sayfalars { get; set; }
    }
}
