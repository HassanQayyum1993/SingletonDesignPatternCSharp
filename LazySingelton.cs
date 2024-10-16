public sealed class LazySingleton
{
    private LazySingleton() { }
    private static readonly Lazy<LazySingleton> Lazy = new Lazy<LazySingleton>(() => new LazySingleton());

    public static LazySingleton Instance
    {
        get
        {
            return Lazy.Value;
        }
    }
}
