using currency;
using System.Linq;
internal class Program
{
    static Dictionary<string,Currency> GetCurrencies()
    {
        return new Dictionary<string, Currency>
        {
            {"USD",new Currency("USD","United States Dollar",1)},
            {"EUR",new Currency("EUR","Euro",0.83975) },
            {"GBP", new Currency("GBP","British Pound",0.74771) },
            {"CAD", new Currency("CAD","Canadian Dollar",1.30724) },
            {"INR", new Currency("INR","Indian Rupee", 73.04) },
            {"MXN", new Currency("MXN","Mexican Peso",21.7571) },

        };
    }
    private static void Main(string[] args)
    {
        var currencies = GetCurrencies();
        Console.WriteLine("Check the rate for");
        var userInput = Console.ReadLine();

        var index = 1;
        var name = "Goofy";
        // var something; <- error
        Currency selectedCurrency = null;
        if(currencies.TryGetValue(userInput, out selectedCurrency))
        {
            Console.WriteLine($"Current rate for USD to {selectedCurrency.currencyName} is {selectedCurrency.Rate}");
        }
        else
        {
            Console.WriteLine("Code doesn't match");
        }
    }
}