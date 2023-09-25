using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Data;
using EntityLayer.Entities;
using Estate.UI.Areas.Admin.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

builder.Services.AddDbContext<DataContext>(conf => conf.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")).UseLazyLoadingProxies());

builder.Services.AddIdentity<UserAdmin, IdentityRole>() // Identity hizmetlerini ekleyin
    .AddEntityFrameworkStores<DataContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(opt =>
{
    opt.SignIn.RequireConfirmedPhoneNumber = false;
    opt.SignIn.RequireConfirmedEmail = false;
    opt.SignIn.RequireConfirmedAccount = false;

    opt.Password.RequireDigit = false;
    opt.Password.RequiredLength = 8;
    opt.Password.RequireLowercase = false;
    opt.Password.RequireUppercase = false;
    opt.Password.RequireNonAlphanumeric = false;
    opt.User.AllowedUserNameCharacters = "abc�defg�h�ijklmno�prs�tu�vyzABC�DEFG�HI�JKLMNO�PRS�TU�VYZ0123456789-._";
});

builder.Services.ConfigureApplicationCookie(opt =>
{
    opt.LoginPath = "/Admin/Admin/Login/";
    opt.LogoutPath = "/Admin/Admin/LogOut";
    opt.AccessDeniedPath = "/Admin/Admin/AccessDeniedPath";
    opt.ExpireTimeSpan = TimeSpan.FromMinutes(6);
});

builder.Services.AddSession();
builder.Services.AddScoped<AdvertService, AdvertManager>();
builder.Services.AddScoped<CityService, CityManager>();
builder.Services.AddScoped<DistrictService, DistrictManager>();
builder.Services.AddScoped<GeneralSettingsService, GeneralSettingsManager>();
builder.Services.AddScoped<ImageService, ImageManager>();
builder.Services.AddScoped<NeighborhoodService, NeighborhoodManager>();
builder.Services.AddScoped<SituationService, SituationManager>();
builder.Services.AddScoped<TypeService, TypeManager>();
builder.Services.AddScoped<IAdvertRepository, EfAdvertRepository>();
builder.Services.AddScoped<ICityRepository, EfCityRepository>();
builder.Services.AddScoped<IDistrictRepository, EfDistrictRepository>();
builder.Services.AddScoped<IGeneralSettingsRepository, EfGeneralSettingsRepository>();
builder.Services.AddScoped<IImageRepository, EfImageRepository>();
builder.Services.AddScoped<INeighborhoodRepository, EfNeighborhoodRepository>();
builder.Services.AddScoped<ISituationRepository, EfSituationRepository>();
builder.Services.AddScoped<ITypeRepository, EfTypeRepository>();
builder.Services.AddScoped<DataContext>();
var app = builder.Build();

app.PrepareDatabase().GetAwaiter().GetResult();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication(); // Kimlik do�rulama ekleyin
app.UseAuthorization();
app.UseSession();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "Area",
        pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}"
    );
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "Area",
      pattern: "{area:exists}/{controller=User}/{action=Index}/{id?}"
    );
});



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();