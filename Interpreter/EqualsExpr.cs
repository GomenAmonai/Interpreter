namespace Interpreter;

public class EqualsExpr : BinaryExpr
{
    public EqualsExpr(IExpr left, IExpr right) : base(left, right) { }
    
    public override int Calculate() => left.Calculate() == right.Calculate() ? 1 : 0;
}

