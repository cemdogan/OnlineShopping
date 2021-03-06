﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using OnlineShopping.Northwind.MvcWebUI.Middlewares;
using OnlineShopping.Northwind.Business.Abstract;
using OnlineShopping.Northwind.Business.Concrete;
using OnlineShopping.Northwind.DataAccess.Abstract;
using OnlineShopping.Northwind.DataAccess.Concrete.EntityFramework;
using OnlineShopping.Northwind.MvcWebUI.Services;
using OnlineShopping.Northwind.MvcWebUI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;

namespace OnlineShopping.Northwind.MvcWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDal, EFProductDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<ICartSessionService, CartSessionService>();
            services.AddDbContext<CustomIdentityDbContext>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NorthWind;Trusted_Connection=true"));
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>().AddEntityFrameworkStores<CustomIdentityDbContext>().AddDefaultTokenProviders();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSession();
            services.AddDistributedMemoryCache();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseNodeModules(env.ContentRootPath);
            app.UseAuthentication();
            app.UseSession();
            app.UseMvcWithDefaultRoute();
            app.UseMvc(ConfigureRoutes);
        }

        private void ConfigureRoutes(IRouteBuilder obj)
        {
            obj.MapRoute("Default", "{controller=Product}/{action=Index}/{id?}");
        }
    }
}
