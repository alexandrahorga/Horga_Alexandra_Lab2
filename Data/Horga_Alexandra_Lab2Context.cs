using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Horga_Alexandra_Lab2.Models;

namespace Horga_Alexandra_Lab2.Data
{
    public class Horga_Alexandra_Lab2Context : DbContext
    {
        internal readonly IEnumerable<object> Author;

        public Horga_Alexandra_Lab2Context (DbContextOptions<Horga_Alexandra_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Horga_Alexandra_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Horga_Alexandra_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Horga_Alexandra_Lab2.Models.Category>? Category { get; set; }

        public DbSet<Horga_Alexandra_Lab2.Models.Author>? Author_1 { get; set; }

       
      

        
    }
}
