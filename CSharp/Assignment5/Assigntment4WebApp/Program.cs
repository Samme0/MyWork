using Assigntment4WebApp.ViewFunctions;
using Assigntment5WebApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Assignment5DbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<OrderEntityFunctions>();

builder.Services.AddScoped<FoodViewFunctions>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<Assignment5DbContext>();
    context.Database.Migrate(); // Ensure database is created and up-to-date
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
name: "default",
pattern: "{controller=Food}/{action=Index}/{id?}");

app.Run();
