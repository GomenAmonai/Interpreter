using System.Linq.Expressions;

namespace Interpreter;

public class PlusExpr : BinaryExpr
{
    public PlusExpr(VarExpr left, VarExpr right) : base(left, right)
    {
        
    }

    public override int Calculate() => left.Calculate() + right.Calculate();
}