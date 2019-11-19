using liriksi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.EF
{
    public partial class LiriksiContext : DbContext
    {
        public LiriksiContext()
        {
        }
        public LiriksiContext(DbContextOptions<LiriksiContext> options)
            : base(options)
        {
        }

        public DbSet<Song> Song { get; set; }
        public DbSet<Album> Album { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserType> UserType { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-CP7742G; Database=liriksiDB; Trusted_Connection=true;"); 
        //}
    }
}
