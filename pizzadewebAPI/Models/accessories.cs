using System.ComponentModel.DataAnnotations;

namespace pizzadewebAPI.Models{

    public class Accessories{
        [Key]
        public int id{ get; set; }
        public string type {get; set;}
        public string name { get; set;}
        public string allergens { get; set; }
        public int price { get; set; }
    }

}