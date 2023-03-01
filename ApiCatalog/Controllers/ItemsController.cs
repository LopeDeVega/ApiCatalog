using ApiCatalog.Repositories;
using Microsoft.AspNetCore.Mvc;
using ApiCatalog.Entites;

namespace ApiCatalog.Controllers;

[ApiController]
[Route("Items")]
public class ItemsController : ControllerBase
{
    // Instaciate items
    private readonly InMemItemsRepository inMemItemsRepository;

    public ItemsController() {

        inMemItemsRepository = new InMemItemsRepository();
    }

    [HttpGet]
    public IEnumerable<Items> GetItems()
    {
        var items = inMemItemsRepository.GetItems();
        return items;
    }

    [HttpGet("{id}")]
    public Items GetItem(Guid id)
    {
        var item = inMemItemsRepository.GetItem(id);

        if (item.Equals(null))
        {
            Console.WriteLine("Errorrrrrrr!!!!!");
        }

        return item;
    }
}
