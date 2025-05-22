using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Domin.Entities
{
    public class StockEntry
    {

        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
    }
}
