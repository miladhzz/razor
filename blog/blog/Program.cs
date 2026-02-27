using blog.Data;
using blog.services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages().
  AddRazorRuntimeCompilation();

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(
  builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddIdentity<IdentityUser, IdentityRole>().
  AddEntityFrameworkStores<AppDbContext>().
  AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(options =>
{
  options.LoginPath = "Auth/Login";  
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Error");
  app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
