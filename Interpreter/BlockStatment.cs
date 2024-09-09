namespace Interpreter;

public class BlockStatment : IStatment
{
    private IReadOnlyList<IStatment> statments;

    public BlockStatment(params IStatment[] statments)
    {
        this.statments = statments.ToList();
    }

    public void Execute()
    {
        foreach (IStatment statment in statments)
            statment.Execute();
    }
}