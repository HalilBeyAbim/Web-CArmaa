namespace WebApplication2.Models
{
    public class Slider
    {
        public int Id { get; set; }

        public string? MainTitle { get; set; }

        public string? SubTitele { get; set; }

        public string? ImageUrl { get; set; }

        public Shoes? shoes { get; set; }
        public int  CategoryId { get; set; }
        public string? SubTitle { get; internal set; }
    }
}
