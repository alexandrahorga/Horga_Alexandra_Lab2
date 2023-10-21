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
        public Horga_Alexandra_Lab2Context (DbContextOptions<Horga_Alexandra_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Horga_Alexandra_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Horga_Alexandra_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorID);
        }
    }
}
