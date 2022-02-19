using Microsoft.EntityFrameworkCore;
using Moment3_CD.Models;

namespace Moment3_CD.Data
{
    public class CdContext : DbContext
    {
        public CdContext(DbContextOptions<CdContext> options) : base(options)
        {


        }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Cd> Cd { get; set; }


    }
}
