﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CataloMarketing.Api;

[Table("Categories")]
public class Category
{
  
  public int Id { get; set; }

  [Required]
  [StringLength(80)]
  public string? Name { get; set; }

  [Required]
  [StringLength(300)]
  public string? ImageUri { get; set; }

  [JsonIgnore]
  public ICollection<Product>? Products { get; set; }
}
