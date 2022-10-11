
internal class Program
{
    private static void Main(string[] args)
    {
        static void DisplayElements(List<int> list)
        {
            Console.WriteLine("** List **");
            foreach (int element in list)
            {
                Console.Write(element+", ");
                
            }
            Console.WriteLine();
        }
        List<int> intList = new List<int>() { 4 , 2, 0 };
        
        // conversion error intList.Add("7");

        DisplayElements(intList);

        Console.WriteLine("Enter new element: ");
        
        intList.Add(int.Parse(Console.ReadLine()));

        DisplayElements(intList);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Remove at:");

        List<int> intList2 = new List<int>() { 6,1,2,3,4};
        DisplayElements(intList2);

        intList2.RemoveAt(3); // Remove element at specified index
        DisplayElements(intList2);

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Remove all:");

        List<int> intList3 = new List<int>() { 6, 1, 2, 3, 4 };
        DisplayElements(intList3);

        bool IsGreaterThan3(int x) { return x > 3; }
        
        intList3.RemoveAll(IsGreaterThan3); // remove elements that fulfill condition
        DisplayElements(intList3);

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Remove:");

        List<int> intList4 = new List<int>() { 6, 1, 1, 3, 4 };
        DisplayElements(intList4);

        intList4.Remove(1);    //remove element with specified value
        DisplayElements(intList4);

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Remove Range:");


        List<int> intList5 = new List<int>() { 6, 1, 2, 3, 4 };
        DisplayElements(intList5);

        intList5.RemoveRange(2, 3); // remove elements at specified index in range
        DisplayElements(intList5);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();


        List<int>listToSort = new List<int> { 7,4,3,1,20,8,100,6,14 };
        DisplayElements(listToSort);
        Console.WriteLine("Sorting list");
        listToSort.Sort();
        DisplayElements(listToSort);

    }
}