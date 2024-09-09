namespace Interpreter
{
    public class IfElseStatment : IStatment
    {
        private IExpr condition;
        private IStatment then;
        private IStatment @else;

        public IfElseStatment(IExpr condition, IStatment then, IStatment @else)
        {
            this.condition = condition;
            this.then = then;
            this.@else = @else;
        }

        public void Execute()
        {
            if(condition.Calculate() != 0)
                then.Execute();
            else
            {
                @else.Execute();
            }
        }
    }
}