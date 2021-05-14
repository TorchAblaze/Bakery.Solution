using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    public string Name { get; set; }

    public Vendor(string name)
    {
      Name = name;
    }
  }
}