using MacroApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MacroApp.DbDataContext
{
    internal class DataContext : DbContext
    {
        public DbSet<Operator> Operators { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder option)
        => option.UseSqlite("Data Source=macroapp.db");

    }
}
