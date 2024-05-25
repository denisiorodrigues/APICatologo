﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CataloMarketing.Api;

[Table("Products")]
public class Product
{
  [Key]
  public int Id { get; set; }
  
  [Required]
  [StringLength(80)]
  public string? Name { get; set; }

  [Required]
  [StringLength(300)]
  public string? Description { get; set; }

  [Required]
  [Column(TypeName ="decimal(10,2)")]
  public Decimal Price { get; set; }   
  
  [Required]
  [StringLength(300)]
  public string? ImageUri { get; set; }
  
  public float Stok { get; set; }
  public DateTime CreatedDate { get; set; }
  public int CategoryId { get; set; }

  [JsonIgnore]
  public Category? Category { get; set; }
}
