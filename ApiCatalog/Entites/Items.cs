namespace ApiCatalog.Entites;

public class Items
{
    /// <summary>
    /// Unit is use to make that field immutable
    /// </summary>
    public Guid Id { get; init; }
    public string Name { get; init; }
    public decimal Price { get; init; }
    public DateTimeOffset createdDate { get; init; }

}
