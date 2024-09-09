namespace Interpreter
{
    public class IncrementExpr : IExpr
    {
        private VarExpr variable;

        public IncrementExpr(VarExpr variable)
        {
            this.variable = variable;
        }

        public int Calculate()
        {
            int oldValue = variable.Value;
            variable.Value++;
            return oldValue;
        }
    }
}