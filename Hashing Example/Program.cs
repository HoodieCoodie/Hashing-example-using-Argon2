using Hashing_Example.Models;

namespace Hashing_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            Console.WriteLine("Registration\n");

            Console.WriteLine("Enter login:");
            string name = Console.ReadLine();

            Console.WriteLine("\nEnter password:");
            string password = Console.ReadLine();

            account.Register(name, password);

            account.GetUsers();

            Console.ReadLine();
        }
    }
}