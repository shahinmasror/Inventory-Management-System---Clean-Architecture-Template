using InventoryManagementSystem.Domin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Application.Interfases
{
    public interface IItemService
    {   
    Task<IEnumerable<Item>> GetAllAsync();
    Task<Item?> GetByIdAsync(Guid id);
    Task<Item> CreateAsync(Item item);
    Task<Item> UpdateAsync(Item item);
    Task<bool> DeleteAsync(Guid id);
    }
    
}
