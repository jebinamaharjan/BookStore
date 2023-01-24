using BookStoreApplication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApplication.Data
{
    public class BookStoreContext : IdentityDbContext<ApplicationUser>
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options)
            :base(options)
        {

        }
        public DbSet<Books> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<BookGallery> BookGallery { get; set; }
    }
}
