namespace $rootnamespace$
{
    public interface IValuable<TNullable> where TNullable : IValuable<TNullable>, new()
    {
        bool IsNull { get; }
    }
}