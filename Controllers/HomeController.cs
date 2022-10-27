using Microsoft.AspNetCore.Mvc;
using WebApplication2.DAL;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index(List<Slider> sliders)
        {
            List<Shoes> shoes = new List<Shoes>()
            {
                new Shoes
                {
                    Id = 1,
                    ImageUrl="bal1.jpg",
                },
                new Shoes
                {
                    Id = 2,
                    ImageUrl="bal2.webp",
                },
                new Shoes
                {
                    Id = 3,
                    ImageUrl="bal3.jpg",
                },
                new Shoes
                {
                    Id = 4,
                    ImageUrl="bal4.webp",
                },
                new Shoes
                {
                    Id = 5,
                    ImageUrl="bal5.jpg",
                },

            };

            HomeVM model = new HomeVM
            {
                Sliders = (List<Slider>?)new List<Slider>()
            {
                new Slider
                {
                    Id= 1,
                    MainTitle = "Frida Kahlo",
                    SubTitle = "A class",
                    ImageUrl ="usaq.jpg",
                },
                 new Slider
                {
                    Id= 2,
                    MainTitle = "Albert Einstein",
                    SubTitle = "A class",
                    ImageUrl ="usaq2.jpg",
                },
                  new Slider
                {
                    Id= 1,
                    MainTitle = "Edward Scissorhands",
                    SubTitle = "A class",
                    ImageUrl ="usaq3.jpg",
                }
            },
                Shoes = shoes,
            };
            return View(model);
            _dbContext.Sliders.ToList();
            return View();
        }
    }
}
