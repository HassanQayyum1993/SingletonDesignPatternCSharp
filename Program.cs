
class Program()
{
    public static void Main()
    {
        var singleton1 = DoubleCheckSingleton.Instance;
        var singleton2 = LazySingleton.Instance;
    }
}
