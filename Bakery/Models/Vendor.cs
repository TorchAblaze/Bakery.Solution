using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
    }
  }
}