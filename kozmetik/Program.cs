using kozmetik.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("conn");
builder.Services.AddDbContext<cosmeticsDBContext>(options =>options.UseSqlServer(connectionString));


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.Use(async (context, next) =>
{
    await next();
    if (context.Response.StatusCode == 404)
    {
        context.Request.Path = "/Home/SayfaHatali";
        await next();
    }
});//Badlinq,badrequest durumlarýna karþý client yönlendirme



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(name: "default2",
                pattern: "/{action}",
                defaults: new { controller = "home", action = "index" });

app.MapControllerRoute(name: "default3",
                pattern: "/{kategori}",
                defaults: new { controller = "home", action = "index"  });



app.Run();
