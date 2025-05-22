using InventoryManagementSystem.Domin.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.InfraStructure.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Item> Items => Set<Item>();
        public DbSet<Supplier> Suppliers => Set<Supplier>();
        public DbSet<StockEntry> StockEntries => Set<StockEntry>();
        public DbSet<Sale> Sales => Set<Sale>();
    }
}
