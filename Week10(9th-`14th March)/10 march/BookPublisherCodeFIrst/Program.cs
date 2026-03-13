using BookPublisherCodeFIrst.Models;
using Microsoft.EntityFrameworkCore;

namespace BookPublisherCodeFIrst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var cs1 = builder.Configuration.GetConnectionString("cs1");

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<BookDbContext>(options =>options.UseSqlServer(cs1));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
