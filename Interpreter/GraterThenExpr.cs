namespace Interpreter;

public class GraterThenExpr : BinaryExpr
{
    public GraterThenExpr(IExpr left, IExpr right) : base(left, right) { }
    
    public override int Calculate() =>left.Calculate() > right.Calculate() ? 1 : 0;
}