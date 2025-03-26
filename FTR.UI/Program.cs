using FTR.DL;
using FTR.BL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyConn")));

builder.Services.AddScoped<IPersonalDetailsRepo, PersonalDetailsRepo>();
builder.Services.AddScoped<IPersonalDetailsService, PersonalDetailsService>();
builder.Services.AddScoped<IForeignTravelRequestRepo, ForeignTravelRequestRepo>();
builder.Services.AddScoped<IForeignTravelRequestService, ForeignTravelRequestService>();
// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddServerSideBlazor();

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
//app.MapBlazorHub();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
