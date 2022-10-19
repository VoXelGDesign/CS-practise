internal class Program
{
    public static IEnumerable<int> GetData()
    {
        Console.WriteLine("Get data start");
        var result = new List<int>();
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Get data element:{i}");
            result.Add(i);
        }
        Console.WriteLine("Get data end");
        return result;
    }
    public static IEnumerable<int> GetYieldedData()
    {
        Console.WriteLine("Get data start");
        for (int i =1; i <9; i++)
        {
            Console.WriteLine($"Get data element:{i}");
            yield return i;
            if(i % 3 == 0)
            {
                yield break;
            }
        }
        Console.WriteLine("Get data end");
    }
    private static void Main(string[] args)
    {
        var yieldedData = GetYieldedData();
        foreach (int element in yieldedData)
        {
            Console.WriteLine($"Main element: {element}");
            if(element > 5)
            {
                break;
            }
        }
    }
}