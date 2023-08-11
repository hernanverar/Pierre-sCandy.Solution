

namespace PierreSweets.Models;
{
  public class Treat
  {
    public int TreatId { get; set; }
    // [Required(ErrorMessage = "The Treat's name can't be empty!")]
    public string Name { get; set; }
    public string  Description { get; set; }
    // public List<TreatFlavor> JoinEntities { get;}
    // public ApplicationUser User { get; set; }
  }
}
