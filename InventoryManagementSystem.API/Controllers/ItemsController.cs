using InventoryManagementSystem.Application.Interfases;
using InventoryManagementSystem.Domin.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,Manager")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemsController(IItemService itemService) => _itemService = itemService;

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _itemService.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var item = await _itemService.GetByIdAsync(id);
            return item is null ? NotFound() : Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Item item)
        {
            var created = await _itemService.CreateAsync(item);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, Item item)
        {
            if (id != item.Id) return BadRequest();
            return Ok(await _itemService.UpdateAsync(item));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _itemService.DeleteAsync(id);
            return result ? NoContent() : NotFound();
        }
    }
}
