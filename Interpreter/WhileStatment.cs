namespace Interpreter;

public class WhileStatment : IStatment
{
    private IExpr condition;
    private IStatment body;

    public WhileStatment(IExpr condition, IStatment body)
    {
        this.condition = condition;
        this.body = body;
    }

    public void Execute()
    {
        while (condition.Calculate() != 0)
        {
            body.Execute();
        }
    }
}