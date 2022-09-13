using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using shoppingAPPMVC.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication().AddFacebook(config =>
{
    config.AppId = "1398900413965725";
    config.AppSecret = "a2ff81cb0d85b5ba9e8cf1a38e8f25fa";
});

builder.Services.AddAuthentication().AddGoogle(config =>
{
    config.ClientId = "708725435803-d866c6lbtugkih7tlc97nja8oc34jtv2.apps.googleusercontent.com";
    config.ClientSecret = "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";
});
//builder.Services.AddAuthentication().Add

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
