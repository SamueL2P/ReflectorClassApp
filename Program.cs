using ReflectorClassApp.Models;

namespace ReflectorClassApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Reflector reflector = new Reflector();

            Console.WriteLine(reflector.ShowDetails(typeof(Customer))); 
            Console.WriteLine(reflector.ShowDetails(typeof(Account))); 
        }
    }
}
