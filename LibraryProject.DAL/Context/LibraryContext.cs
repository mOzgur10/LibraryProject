using LibraryProject.DATA.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DAL.Context
{
    public class LibraryContext: DbContext
    {
        public DbSet<BookHistory> BookHistorys { get; set; }
        public DbSet<BookScience> BookSciences { get; set; }
        public DbSet<BookNovel> BookNovels { get; set; }

        public DbSet<Member> Members { get; set; }
        public DbSet<BorrowedBook> BorrowedBooks { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BorrowedBook>()
            .HasOne(bb => bb.Member)
            .WithMany()
            .HasForeignKey(bb => bb.MemberId);

            modelBuilder.Entity<BorrowedBook>()
                .HasOne(bb => bb.Book)
                .WithMany()
                .HasForeignKey(bb => bb.BookId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
