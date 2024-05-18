using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CataloMarketing.Api;

[Route("categories")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ApiContext _context;

    public CategoryController(ApiContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Category>> ListAll() 
    {
        return _context.Categories.ToList();
    }

    [HttpGet("{id:int}", Name = "GetCategory")]
    public ActionResult<Category> GetById(int id) 
    {
        var category = _context.Categories.FirstOrDefault(p => p.Id == id);

        if(category is null) 
        {
            return NotFound("Category not found.");
        }

        return  Ok(category);
    }

    [HttpPost]
    public ActionResult<Category> Create(Category category) 
    {   
        if(category is null) 
        {
            return BadRequest();
        }

        _context.Categories.Add(category);
        _context.SaveChanges();

        return new CreatedAtRouteResult("GetCategory", new { id = category.Id }, category);
    }

    [HttpPut("{id:int}")]
    public ActionResult<Category> Update(int id, Category category) 
    {   
        if(id != category.Id) 
        {
            return BadRequest();
        }

        _context.Entry(category).State = EntityState.Modified;
        _context.SaveChanges();

        return Ok(category);
    }

    [HttpDelete("{id:int}")]
    public ActionResult<Category> Delete(int id) 
    {
        var category = _context.Categories.FirstOrDefault(p => p.Id == id);

        if(category is null) 
        {
            return NotFound("Category not found.");
        }

        _context.Categories.Remove(category);
        _context.SaveChanges();

        return  Ok(category);
    }
}
