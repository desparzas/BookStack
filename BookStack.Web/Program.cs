using BookStack.Web.Components;
using BookStack.Web.Data;
using BookStack.Web.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Add controllers for Web API
builder.Services.AddControllers();

// Add HttpClient for API calls
builder.Services.AddHttpClient();

// Add DbContext with SQLite
// Use /app/data directory for database in Docker, or current directory in development
var dbPath = builder.Environment.IsProduction()
    ? "/app/data/bookstack.db"
    : "bookstack.db";

builder.Services.AddDbContext<BookStackContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("BookStackContext")
        ?? $"Data Source={dbPath}"));

// Add authentication services
builder.Services.AddScoped<AuthService>();
builder.Services.AddSingleton<AuthStateService>();

var app = builder.Build();

// Initialize database with seed data
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<BookStackContext>();

        // Ensure database is created
        context.Database.EnsureCreated();

        // Seed initial data
        SeedData.Initialize(context);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while seeding the database.");
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Map API controllers
app.MapControllers();

app.Run();
