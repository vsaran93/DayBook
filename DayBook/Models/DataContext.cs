using System;
using Microsoft.EntityFrameworkCore;

namespace DayBook.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Transaction> Transactions { get; set; } = null!;
    }
}

