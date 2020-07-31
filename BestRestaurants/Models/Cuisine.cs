using System.Collections.Generic;
using System.ComponentModel;

namespace BestRestaurants.Models
{
  public class Cuisine
  {
    public Cuisine()
    {
      this.Restaurants = new HashSet<Restaurant>();
    }

    public int CuisineId { get; set; }
    [DisplayName("Type of Cuisine")]
    public string Name { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; }
  }
}