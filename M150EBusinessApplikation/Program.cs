using System.Net.NetworkInformation;
using M150EBusinessApplikation.Areas.Identity;
using M150EBusinessApplikation.Data;
using M150EBusinessApplikation.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

var defaultConnection = builder.Configuration.GetConnectionString("DefaultConnection");


builder.Services.AddDbContextPool<ApplicationDbContext>(options =>
    options.UseLazyLoadingProxies().UseSqlServer(defaultConnection));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false).AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
});


builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddBootstrapBlazor();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<ChampionService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<HttpClient>();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSignalR();
builder.Services.AddLogging();
builder.Services.AddCors(options =>
{
    options.AddPolicy("M150BlazorApp", builder =>
        builder.WithOrigins("https://localhost:44351/")
            .AllowAnyHeader()
            .WithMethods("GET", "POST")
            .AllowCredentials());
});


var app = builder.Build();
app.UseCors("M150BlazorApp");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseDeveloperExceptionPage();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();
app.UseWebSockets();


app.Run();



