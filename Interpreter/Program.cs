namespace Interpreter
{

    internal class Program  {
        static void Main(string[] args)
        {
            new BlockStatment(
                new ExprStatment(
                    new AssignExpr(
                        new VarExpr("a"),
                        new ConstExpr(1)
                    )
                ),
                new ExprStatment(
                    new AssignExpr(
                        new VarExpr("b"),
                        new ConstExpr(2)
                    )
                ),
                new ExprStatment(
                    new AssignExpr(
                        new VarExpr("a"),
                        new PlusExpr(
                            new VarExpr("a"),
                            new VarExpr("b")
                        )
                    )
                )
            ).Execute();
        }
    }
}