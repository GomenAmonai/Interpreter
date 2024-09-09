namespace Interpreter;

public class ExprStatment : IStatment
{
    private IExpr expr;
    public ExprStatment(IExpr expr) => this.expr = expr;

    public void Execute() => expr.Calculate();
}
