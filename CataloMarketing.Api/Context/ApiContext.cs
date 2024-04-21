using Microsoft.EntityFrameworkCore;

namespace CataloMarketing.Api;

public class ApiContext : DbContext
{
  public ApiContext(DbContextOptions<ApiContext> options) : base(options)
  {
  }
  
  public DbSet<Category>? Categories { get; set; }
  
  public DbSet<Product>? Products { get; set; }
}
