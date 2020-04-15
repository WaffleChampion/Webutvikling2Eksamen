using System.ComponentModel.DataAnnotations;

namespace pizzadewebAPI.Models{

    public class Dishes{
        [Key]
        public int id { get; set; }
        public string dishType{ get; set; }
        public string dishName{ get; set; }
        public string ingredients{get; set;}
        public string vegetarian {get; set;}
        public string allergens{ get; set;}
        public int price{ get; set;}

        public string imgSrc{get; set;}
    }

}