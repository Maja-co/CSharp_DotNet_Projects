using Microsoft.EntityFrameworkCore;
using Shared;

namespace Api.Data;

public class CalculatorContext : DbContext {
    public DbSet<Calculation> Calculations { get; set; }
    
    public CalculatorContext(DbContextOptions<CalculatorContext> options) : base(options) {
    }
}