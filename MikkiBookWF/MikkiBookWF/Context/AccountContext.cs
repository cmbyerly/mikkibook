using Microsoft.EntityFrameworkCore;
using MikkiBookWF.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikkiBookWF.Context
{
    public class AccountContext : DbContext
    {
        public DbSet<AccountTransaction> AccountTransactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=trans.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountTransaction>()
                .ToTable("TRANS_TABLE")
                .HasKey(i => i.Id);
        }
    }
}
