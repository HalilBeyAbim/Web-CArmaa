namespace WebApplication2.Models
{
    public class Shoes
    {
        public int Id { get; set; }
        public string?  Name { get; set; }
         
        public List<Slider>? Sliders {get; set;}
        public string ImageUrl { get; internal set; }
    }
}
