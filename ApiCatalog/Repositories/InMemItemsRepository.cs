using ApiCatalog.Entites;

namespace ApiCatalog.Repositories;

public class InMemItemsRepository
{
    private readonly List<Items> items = new()
    {
        new Items{ Id = Guid.NewGuid(), Name = "Potion", Price = 9 , createdDate = DateTimeOffset.UtcNow },
        new Items{ Id = Guid.NewGuid(), Name = "Iron Sword", Price = 20, createdDate = DateTimeOffset.UtcNow},
        new Items{ Id = Guid.NewGuid(), Name = "Bronze Shield", Price = 18, createdDate = DateTimeOffset.UtcNow}
    };

    public IEnumerable<Items> GetItems()
    {
        return items;
    }

    public Items GetItem(Guid id)
    {
        return items.FirstOrDefault(x => x.Id == id); //items.Where(items => items.Id == id).SingleOrDefault();
    }
}
