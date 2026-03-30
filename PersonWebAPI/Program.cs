var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


/*
 *
 * Når du fremover opretter et nyt Web API-projekt i Rider, skal du bare scrolle lidt ned i det vindue, hvor du giver projektet et navn.
 * Der burde være et par vigtige indstillinger, du kan slå til:
   
   Sørg for at vælge typen "ASP.NET Core Web API".
   
   Kryds af i "Use controllers" (så du får den rigtige arkitektur fra start og slipper for minimal-api gøglet).
   
   Kryds af i "Enable OpenAPI support" (det sørger for, at pakkerne og opsætningen til Swagger/Scalar er der automatisk).
 * 
*/