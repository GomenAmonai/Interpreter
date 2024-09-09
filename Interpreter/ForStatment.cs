namespace Interpreter
{
    public class ForStatment : IStatment
    {
        private IStatment initialization;
        private IExpr condition;
        private IStatment increment;
        private IStatment body;

        public ForStatment(IStatment initialization, IExpr condition, IStatment increment, IStatment body)
        {
            this.initialization = initialization;
            this.condition = condition;
            this.increment = increment;
            this.body = body;
        }

        public void Execute()
        {
            initialization.Execute();
            while (condition.Calculate() != 0)
            {
                body.Execute();
                increment.Execute();
            }
        }
    }
}

