using Microsoft.AspNetCore.Mvc;

namespace CataloMarketing.Api;

[Route("api/[Controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly ApiContext _apiContext;

    public ProductsController(ApiContext apiContext)
    {
        _apiContext = apiContext;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Product>> Get()
    {
        var products = _apiContext.Products.ToList();

        if(products is null) return NotFound("Products not found");

        return Ok(products);
    }

    [HttpGet("{id:int}", Name = "GetById")]
    public ActionResult<Product> GetById(int id)
    {
        var product = _apiContext.Products.FirstOrDefault(product => product.Id == id);

        if(product is null) 
        {
            return NotFound("product not found");
        }

        return Ok(product);
    }

    [HttpPost]
    public ActionResult Create(Product product) 
    {
        if(product is null)
            return BadRequest();

        _apiContext.Products.Add(product);
        _apiContext.SaveChanges();

        return new CreatedAtRouteResult("GetById", new { id = product.Id }, product);
    }
}
