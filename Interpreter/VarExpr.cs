namespace Interpreter
{
    public class VarExpr : IExpr
    {
        public static IDictionary<string, IExpr> Vars = new Dictionary<string, IExpr>();
        
        public string Name { get; }
        public int Value { get; set; }
        public VarExpr(string name) => Name = name;
        public int Calculate() => Vars[Name].Calculate();
    }
}