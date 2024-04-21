namespace CataloMarketing.Api;

public class Product
{
  public int Id { get; set; }
  public string? Name { get; set; }
  public string? Description { get; set; }
  public Decimal Price { get; set; }   
  public string? ImageUri { get; set; }
  public float Stok { get; set; }
  public DateTime CreatedDate { get; set; }
  public int CategoryId { get; set; }
  public Category? Category { get; set; }
}
