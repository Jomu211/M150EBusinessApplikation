using System.Net.NetworkInformation;
using M150EBusinessApplikation.Areas.Identity;
using M150EBusinessApplikation.Data;
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
var secondConnection = builder.Configuration.GetConnectionString("SecondaryConnection");

bool defaultString = CheckServerAvailability(defaultConnection);
var connectionString = "";

bool CheckServerAvailability(string defaultConnection)
{
    var stringBuilder = new SqlConnectionStringBuilder(defaultConnection);
    var serverAdress = stringBuilder.DataSource;

    try
    {
        Ping pingSender = new Ping();
        PingReply reply = pingSender.Send(serverAdress);
        if (reply.Status == IPStatus.Success)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    catch (PingException)
    {
        return false;
    }
}

connectionString = defaultString ? defaultConnection : secondConnection;

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseLazyLoadingProxies().UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false).AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddBootstrapBlazor();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddScoped<ProtectedSessionStorage>();
builder.Services.AddScoped<HttpClient>();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSignalR();

var app = builder.Build();

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


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors();
app.UseAuthorization();
app.MapControllers();
app.UseWebSockets();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
