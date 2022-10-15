using Project_14;
internal class Program
{
    static List<Person> GetEmployees()
    {
        List<Person> employees = new List<Person>
            {
                new Person("John","Wick",new DateTime(2000,4,7),"111222333"),
                new Person("Bill","Wick",new DateTime(1999,7,7),"012345678"),
                new Person("Mark","Smith",new DateTime(2002,9,1),"789456123"),
                new Person("Bob","Dickens",new DateTime(2003,11,20)),
                new Person("Andrew","Tate",new DateTime(1993,10,11),"111666111"),
                new Person("Ed","Sheeran",new DateTime(2005,8,27),"890765345"),
                new Person("Bill","Wook",new DateTime(1978,3,14),"767555783")
            };

        return employees;
    }
    private static void Main(string[] args)
    {
        List<Person> employees = GetEmployees();
        List<Person> youngEmployees = new List<Person>();
        foreach (Person employee in employees)
        {
            if(employee.DateOfBirth > new DateTime(2000, 1, 1))
            {
                youngEmployees.Add(employee);
            }
            
        }
        Console.WriteLine($"Young employees count: {youngEmployees.Count}");

        
        foreach(Person youngEmployee in youngEmployees)
        {
            if(youngEmployee.firstName == "Bob")
            {
                youngEmployee.SayHi();
            }
        }
    }
}