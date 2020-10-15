using System;
using CFBlog0920.Data;
using CFBlog0920.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CFBlog0920.Areas.Identity.IdentityHostingStartup))]
namespace CFBlog0920.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DefaultConnection")));

                services.AddIdentity<BlogUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultUI()
                    .AddDefaultTokenProviders();

                //services.AddDefaultIdentity<BlogUser>(options => options.SignIn.RequireConfirmedAccount = false)
                //    .AddEntityFrameworkStores<ApplicationDbContext>();
            });
        }
    }
}