using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TiendaOnline.Data;
using TiendaOnline.Data.Entities;
using TiendaOnline.Helpers;

namespace TiendaOnline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<DataContext>(o =>
            {
                o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            builder.Services.AddIdentity<User, IdentityRole>(cfg =>
            {
                cfg.Tokens.AuthenticatorTokenProvider = TokenOptions.DefaultAuthenticatorProvider;
                cfg.SignIn.RequireConfirmedEmail = true;
                cfg.User.RequireUniqueEmail = true;
                cfg.Password.RequireDigit = false;
                cfg.Password.RequiredUniqueChars = 0;
                cfg.Password.RequireLowercase = false;
                cfg.Password.RequireNonAlphanumeric = false;
                cfg.Password.RequireUppercase = false;
                cfg.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                cfg.Lockout.MaxFailedAccessAttempts = 3;
                cfg.Lockout.AllowedForNewUsers = true;
            })
            .AddDefaultTokenProviders()
            .AddEntityFrameworkStores<DataContext>();

            builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
            builder.Services.AddTransient<SeedDb>();
            builder.Services.AddScoped<IUserHelper, UserHelper>();
            builder.Services.AddScoped<ICombosHelper, CombosHelper>();
            builder.Services.AddScoped<IImageHelper, ImageHelper>();
            builder.Services.AddScoped<IMailHelper, MailHelper>();
            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/NotAuthorized";
                options.AccessDeniedPath = "/Account/NotAuthorized";
            });
            


            var app = builder.Build();
            SeedData(app);
            void SeedData(WebApplication app)
            {
                IServiceScopeFactory? scopedFactory = app.Services.GetService<IServiceScopeFactory>();

                using (IServiceScope? scope = scopedFactory.CreateScope())
                {
                    SeedDb? service = scope.ServiceProvider.GetService<SeedDb>();
                    service.SeedAsync().Wait();
                }
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseStatusCodePagesWithReExecute("/error/{0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}