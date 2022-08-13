using System.Collections.Generic;
using System;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public int FlavorId { get; set; }
    public string Description { get; set; }
     public virtual ApplicationUser User { get; set; } 
     
    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
  }
}