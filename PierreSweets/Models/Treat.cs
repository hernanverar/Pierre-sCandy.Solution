using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreSweets.Models
{
    public class Treat
    {
        public int TreatId { get; set; }

        [Required(ErrorMessage = "This field cannot be empty. Please try again.")]
        public string TreatName { get; set; }
        

        public List<TreatFlavor> JoinEntities { get; set; }
    }
}

