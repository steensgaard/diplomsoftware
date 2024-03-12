namespace calculator.Model.Interface.Service;

public class Calculator : ICalculator
{

    double ICalculator.calculate(double oprendLeft, string operation, double oprendRight) => operation switch
    {
        "+" => oprendLeft + oprendRight,
        "-" => oprendLeft - oprendRight,
        "*" => oprendLeft * oprendRight,
        "/" => oprendLeft / oprendRight,
        _ => throw new NotSupportedException("The Operation: " + operation + "is not supported")
    };
        
}
