using System.ComponentModel.DataAnnotations;

namespace pizzadewebAPI{

    public class Desserts{
        [Key]
        public int id { get; set; }
        public string name {get; set;}
        public string Description{get; set;}
        public int price {get; set;}
        public string imageSrc{get; set;}
    }

}