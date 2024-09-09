namespace Interpreter;

public class InputExpr : IExpr
{
    public int Calculate()
    {
        Console.WriteLine("Enter number: ");
        return int.Parse(Console.ReadLine());
    }
}
