using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreSweets.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The Treat's name can't be empty!")]
    public string TreatName { get; set; }
    public string  Description { get; set; }
    public int FlavorId { get; set; }
    public List<TreatFlavor> JoinEntities { get;}
    public Account User { get; set; }
  }
}
