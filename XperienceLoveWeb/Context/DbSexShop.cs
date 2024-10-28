using Microsoft.EntityFrameworkCore;
using XperienceLoveWeb.Models;

namespace XperienceLoveWeb.Context
{
    public class DbSexShop : DbContext
    {
        public DbSexShop(DbContextOptions<DbSexShop>options) : base(options) { }
        public DbSet<Products> Products { get; set; }
        public DbSet<Providers> Providers { get; set; }
        public DbSet<Tipe_of_pay> Tipe_Of_Pays { get; set; }
        public DbSet<Users> Users { get; set; }

    }
}
