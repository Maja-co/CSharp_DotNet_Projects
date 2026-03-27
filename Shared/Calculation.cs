namespace Shared;

public class Calculation {
    public int CalculationId { get; set; }
    public double Operand1{get; set;}
    public double Operand2{get; set;}
    public double Sum{get; set;}
    public MathOperator Operator{get; set;}

    public Calculation() {
    }
}