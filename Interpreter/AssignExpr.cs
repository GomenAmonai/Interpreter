namespace Interpreter
{
    public class AssignExpr : IExpr
    {
        private VarExpr left;
        private IExpr right;

        public AssignExpr(VarExpr left, IExpr right)
        {
            this.left = left;
            this.right = right;
        }

        public int Calculate()
        {
            int value = right.Calculate();
            left.Value = value;
            return value;
        }
    } 
}

