namespace CataloMarketing.Api;

public class Category
{
  public int Id { get; set; }

  public string? Name { get; set; }

  public string? ImageUri { get; set; }

  public ICollection<Product>? Products { get; set; }
}
