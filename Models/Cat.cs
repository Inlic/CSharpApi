using System;
using System.ComponentModel.DataAnnotations;

namespace CSharpApi.Models
{
  public class Cat
  {
    public Cat(string name, string description)
    {
      Name = name;
      Description = description;
    }
    public Cat()
    {

    }
    [Required]
    [MinLength(5)]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    public string Id { get; set; } = Guid.NewGuid().ToString();

  }
}