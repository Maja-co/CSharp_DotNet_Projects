using Api.Data;
using Microsoft.EntityFrameworkCore;
using Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddDbContext<CalculatorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors(options => {
    options.AddPolicy("AllowBlazorClient", policy => {
        policy.SetIsOriginAllowed(_ => true)
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.MapOpenApi();
}

app.UseCors("AllowBlazorClient");

app.MapPost("/calculations", (Calculation newCalculation, CalculatorContext db) => {
    switch (newCalculation.Operator) {
        case MathOperator.Add:
            newCalculation.Sum = newCalculation.Operand1 + newCalculation.Operand2;
            break;
        case MathOperator.Subtract:
            newCalculation.Sum = newCalculation.Operand1 - newCalculation.Operand2;
            break;
        case MathOperator.Multiply:
            newCalculation.Sum = newCalculation.Operand1 * newCalculation.Operand2;
            break;
        case MathOperator.Divide:
            newCalculation.Sum = newCalculation.Operand1 / newCalculation.Operand2;
            break;
    }
    newCalculation.CalculationId = 0;
    db.Calculations.Add(newCalculation);
    db.SaveChanges();
    return Results.Ok(newCalculation);
});

app.Run();