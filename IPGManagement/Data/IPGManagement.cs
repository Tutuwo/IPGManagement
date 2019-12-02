using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IPGManagement.Models
{
    public class IPGManagementDbContext : DbContext
    {
        public IPGManagementDbContext(DbContextOptions<IPGManagementDbContext> options)
            : base(options)
        {
        }

        public DbSet<IPGManagement.Models.Funcionario> Funcionarios { get; set; }
        public DbSet<IPGManagement.Models.Cargo> Cargos { get; set; }

        public DbSet<IPGManagement.Models.Departamento> Departamentos { get; set; }
        public DbSet<IPGManagement.Models.Horario> Horarios {get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // alternate way of specifying a key with two fields:
            // https://stackoverflow.com/questions/5962557/multiple-primary-key-with-asp-net-mvc-3
            modelBuilder.Entity<BookCategory>()
                .HasKey(bc => new { bc.BookId, bc.CategoryId });

            modelBuilder.Entity<Funcionario>()
                .HasOne(b => b.Cargo)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            // No need for doing this
            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.CategoriesBook)
                .HasForeignKey(bc => bc.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            // No need for doing this
            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BooksCategory)
                .HasForeignKey(bc => bc.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }


}
}
