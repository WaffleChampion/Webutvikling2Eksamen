using System.ComponentModel.DataAnnotations;

namespace pizzadewebAPI.Models{

    public class Drinks{
        [Key]
        public int id { get; set; }
        public string type { get; set; }
        public int price {get; set; }
    }

}