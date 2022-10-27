using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using WebApplication2.DAL;

namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddMvc();
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer (builder.Configuration.GetConnectionString("DefaultConnection")));
            var app = builder.Build();
            app.UseRouting();
            app.UseEndpoints(endpoints => endpoints.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}"));
            app.UseStaticFiles();
            

            app.Run();
        }
    }
}