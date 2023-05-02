using kozmetik.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("conn");
builder.Services.AddDbContext<cosmeticsDBContext>(options =>options.UseSqlServer(connectionString));


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.Configure<Microsoft.AspNetCore.Mvc.CookieTempDataProviderOptions>(options =>
{
    options.Cookie.IsEssential = true;
}); /*bunu biz ekledik. g�venlik i�in*/


builder.Services.Configure<CookiePolicyOptions>(options =>
{
    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;
}); /*bunu biz ekledik. g�venlik i�in*/

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.LoginPath        = "/Hesap/Giris";
    options.AccessDeniedPath = "/Hesap/Giris";
    options.LogoutPath       = "/Hesap/Giris";

}); /*bunu biz ekledik. g�venlik i�in*/




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.Use(async (context, next) =>
//{
//    await next();
//    if (context.Response.StatusCode == 404)
//    {
//        context.Request.Path = "/Home/SayfaHatali";
//        await next();
//    }
//});//Badlinq,badrequest durumlar�na kar�� client y�nlendirme



app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseCookiePolicy();      /*bunu biz ekledik. g�venlik i�in*/
app.UseAuthentication();    /*bunu biz ekledik. g�venlik i�in*/


app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(name: "default2",
                pattern: "/{action}",
                defaults: new { controller = "home", action = "index" });

app.MapControllerRoute(name: "default4",
                pattern: "/{action}/{id?}",
                defaults: new { controller = "home", action = "index" });

app.MapControllerRoute(name: "default3",
                pattern: "/{kategori}",
                defaults: new { controller = "home", action = "index"  });

app.Run();
