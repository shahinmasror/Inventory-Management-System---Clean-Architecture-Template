using InventoryManagementSystem.Application.Interfases;
using InventoryManagementSystem.Domin.Entities;
using InventoryManagementSystem.InfraStructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.InfraStructure.Servises
{
  

        public class ItemService : IItemService
        {
            private readonly ApplicationDbContext _context;
            public ItemService(ApplicationDbContext context) => _context = context;

            public async Task<IEnumerable<Item>> GetAllAsync() => await _context.Items.ToListAsync();

            public async Task<Item?> GetByIdAsync(Guid id) => await _context.Items.FindAsync(id);

            public async Task<Item> CreateAsync(Item item)
            {
                _context.Items.Add(item);
                await _context.SaveChangesAsync();
                return item;
            }

            public async Task<Item> UpdateAsync(Item item)
            {
                _context.Items.Update(item);
                await _context.SaveChangesAsync();
                return item;
            }

            public async Task<bool> DeleteAsync(Guid id)
            {
                var item = await _context.Items.FindAsync(id);
                if (item == null) return false;
                _context.Items.Remove(item);
                await _context.SaveChangesAsync();
                return true;
            }
        }
    
}
