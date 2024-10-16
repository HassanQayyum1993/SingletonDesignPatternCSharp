
public sealed class DoubleCheckSingleton
{
    private DoubleCheckSingleton() { }

    private static readonly object lockObj = new int();
    private static DoubleCheckSingleton instance = null;

    public static DoubleCheckSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new DoubleCheckSingleton();
                    }
                }
            }
            return instance;
        }
    }
}