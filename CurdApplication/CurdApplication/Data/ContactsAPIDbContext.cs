using CURDApplication.Models;
using Microsoft.EntityFrameworkCore;
namespace CURDApplication.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {
        }
       public DbSet<Contact> Contants { get; set; }

    }
}
