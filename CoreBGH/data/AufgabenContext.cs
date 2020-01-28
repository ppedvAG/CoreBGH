using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBGH.data
{
    public class AufgabenContext:DbContext
    {
        public AufgabenContext(DbContextOptions<AufgabenContext> options):base(options)
        {

        }

        public virtual DbSet<Aufgaben> Aufgaben { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
