using Microsoft.EntityFrameworkCore;
using BootCamp.Models;

namespace BootCamp.Models
{
    public class Ctx : DbContext
    {
        public Ctx(DbContextOptions<Ctx> options)
            : base(options)
        {
        }

        public DbSet<Section> Section { get; set; }
        public DbSet<Article> Article { get; set; }
        public DbSet<BootCamp.Models.Author> Author { get; set; }
    }
}