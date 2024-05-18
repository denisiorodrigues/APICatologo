﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CataloMarketing.Api;

[Route("api/products")]
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

    [HttpGet("{id:int}", Name = "GetProduct")]
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
        {
            return BadRequest();
        }

        _apiContext.Products.Add(product);
        _apiContext.SaveChanges();

        return new CreatedAtRouteResult("GetProduct", new { id = product.Id }, product);
    }

    [HttpPut("{id:int}")]
    public ActionResult Update(int id, Product product) 
    {
        if(id != product.Id) 
        {
            return BadRequest("The Id product and entity produt don't same");
        }

        _apiContext.Entry(product).State = EntityState.Modified;
        _apiContext.SaveChanges();

        return Ok(product);
    }
}
