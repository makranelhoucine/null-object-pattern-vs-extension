namespace $rootnamespace$
{
    public interface IValuable
    {
        bool IsNull { get; }
    }

    public class Valuable<TNullable> : IValuable where TNullable : Valuable<TNullable>, new()
    {
        public static TNullable Null { get; } = new TNullable();

        public bool IsNull => this is TNullable myself;
    }
}