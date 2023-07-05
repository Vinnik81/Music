using Microsoft.EntityFrameworkCore;
using Music.Extensions;
using Music.Models;
using Music.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

Console.WriteLine(builder.Configuration.GetValue<string>("Title"));
Console.WriteLine(builder.Configuration.GetSection("MusicApi").GetValue<string>("BaseUrl"));
Console.WriteLine(builder.Configuration["MusicApi:BaseUrl"]);

builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
builder.Services.AddSingleton<IRecentMusicStorage, RecentMusicStorage>();

builder.Services.AddMusicApi(option =>
{
    option.BaseUrl = builder.Configuration[("MusicApi:BaseUrl")];
});

builder.Services.AddMemoryCache();

builder.Services.AddDbContext<MusicDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
});

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
