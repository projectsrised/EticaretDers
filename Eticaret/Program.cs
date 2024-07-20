
using Eticaret.BAL.Interfaces;
using Eticaret.BAL.Services;
using Eticaret.DAL.Data;
using Eticaret.Repository.Interfaces;
using Eticaret.Repository.Repositories;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
String connstring = builder.Configuration.GetConnectionString("SqlServerBaglantisi")!;
builder.Services.AddScoped<DbContext, AppDbContext>();
builder.Services.AddScoped<IKategoriRespository, KategoriRepository>();
builder.Services.AddScoped<IMakaleRepository, MakaleRepository>();
builder.Services.AddScoped<IKategoriService, KategoriService>();
builder.Services.AddScoped<IMakaleService, MakaleService>();
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connstring));








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
