using Microsoft.EntityFrameworkCore;
using PametniDomAPP;

using StockContext stockContext = new StockContext();


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


var n1 = new Naprava("Kamera", DateTime.Now);
var n2 = new Naprava("Thermostat", DateTime.Now);

stockContext.NapravaDB.Add(n1);
stockContext.ObvestiloDB.Add(new Obvestilo("Nekaj se premiga na kameri", n1));
stockContext.ObvestiloDB.Add(new Obvestilo("Temp je presegla 25 C", n2));

//stockContext.NapravaDB.RemoveRange(stockContext.NapravaDB);
//stockContext.ObvestiloDB.RemoveRange(stockContext.ObvestiloDB);


stockContext.SaveChanges();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
