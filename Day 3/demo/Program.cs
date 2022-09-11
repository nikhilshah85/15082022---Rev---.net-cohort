using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using demo.Data;
using demo.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("demoContextConnection") ?? throw new InvalidOperationException("Connection string 'demoContextConnection' not found.");

builder.Services.AddDbContext<demoContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<demoUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<demoContext>();

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

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
