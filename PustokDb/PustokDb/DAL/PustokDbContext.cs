using Microsoft.EntityFrameworkCore;
using PustokDb.Models;
using System.Collections.Generic;

namespace PustokDb.DAL
{
    public class PustokDbContext : DbContext
    {
        public PustokDbContext(DbContextOptions<PustokDbContext> options) : base(options)
        {

        }
        public DbSet<Sliders> Sliders { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<BookImages> BookImages { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<BtmPromotions> BtmPromotions { get; set; }
        public DbSet<TopPromotions> TopPromotions { get; set; }
    }
}
