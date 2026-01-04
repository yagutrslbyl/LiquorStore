using LiquorStore.DAL;
using Microsoft.EntityFrameworkCore;

namespace LiquorStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            var app = builder.Build();

            app.UseStaticFiles();

            

            app.MapControllerRoute(
                name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Admin}/{id?}"
                );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id:?}");

            app.Run();
        }
    }
}
