using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreSweets.Models
{
    public class Treat
    {
        public int TreatId { get; set; }
        
        [Required(ErrorMessage = "The Treat's name can't be empty!")]
        public string TreatName { get; set; }
        
        public string Description { get; set; }

        // Add a setter to the JoinEntities property
        public List<TreatFlavor> JoinEntities { get; set; } = new List<TreatFlavor>();
        
        public Account User { get; set; }
    }
}

