
using Cms.Bussiness.Abstract;
using Cms.Bussiness.Concrete;
using Cms.DataAccess.Abstract;
using Cms.DataAccess.Concrete;
using Cms.DataAccess.DataContext;
using Cms.WebUI.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationIdentityDbContext>(options =>
            options.UseNpgsql(@"User ID=postgres;Password=37363736;Server=localhost;Port=5432;Database=crmdb;Integrated Security=true;Pooling=true;"));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationIdentityDbContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                // password

                options.Password.RequireDigit = false; //sayýsal deðer
                options.Password.RequireLowercase = false;//küçük harf
                options.Password.RequiredLength = 6; //minimum karalter
                options.Password.RequireNonAlphanumeric = false; 
                options.Password.RequireUppercase = false;//büyük harf

                options.Lockout.MaxFailedAccessAttempts = 5;//kaç kere yanlýþ girme hakký
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); //tekrar login olmasý için geçmesi gereken süre
                options.Lockout.AllowedForNewUsers = false; //yeni oluþturulan kullanýcý aktif mi

                // options.User.AllowedUserNameCharacters = "";
                options.User.RequireUniqueEmail = true;

                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.SlidingExpiration = true;
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".Cms.Security.Cookie",
                    SameSite = SameSiteMode.Strict
                };

            });

            services.AddControllersWithViews();
            //string mySqlConnectionStr = Configuration.GetConnectionString("connectionString");
            //services.AddDbContextPool<DatabaseContext>(options => options.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr)));
            services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin",
                    builder => builder.WithOrigins("http://localhost:3000"));
            });

            services.AddScoped<IContactFormDal, ContactFormDal>();
            services.AddScoped<IContactFormService, ContactFormManager>();

            services.AddScoped<ILanguageDal, LanguageDal>();
            services.AddScoped<ILanguageService,LanguageManager>();

            services.AddScoped<IPanelUserDal, PanelUserDal>();
            services.AddScoped<IPanelUserService, PanelUserManager>();

            services.AddScoped<ISettingDal, SettingDal>();
            services.AddScoped<ISettingService, SettingManager>();

            services.AddScoped<IUploadFileDal, UploadFileDal>();
            services.AddScoped<IUploadFileService, UploadFileManager>();

            services.AddScoped<IPageContainerDal, PageContainerDal>();
            services.AddScoped<IPageContainerService, PageContainerManager>();

            services.AddScoped<IPageContentDal, PageContentDal>();
            services.AddScoped<IPageContentService, PageContentManager>();

            services.AddScoped<IPageTitleDal, PageTitleDal>();
            services.AddScoped<IPageTitleService, PageTitleManager>();

            services.AddScoped<IVw_TitleContainerDal, Vw_TitleContainerDal>();
            services.AddScoped<IVw_TitleContainerService, Vw_TitleContainerManager>();

            services.AddScoped<IVw_TitleContentDal, Vw_TitleContentDal>();
            services.AddScoped<IVw_TitleContentService, Vw_TitleContentManager>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseCors(builder => builder.WithOrigins("http://localhost:3000").AllowAnyHeader());
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("Default2", "PageContent/{Link?}", new { controller = "PageDetail", action = "Index" });


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{page?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Language}/{action=EditLanguage}/{id?}");


                //endpoints.MapControllerRoute(
                //    name: "default3",
                //    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
