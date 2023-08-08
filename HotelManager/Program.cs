using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            while (true)
            {
                Console.WriteLine("1. Add new client");
                Console.WriteLine("2. Delete client");
                Console.WriteLine("3. Calculate price");
                Console.WriteLine("4. Exit");

                int n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine("Enter client's name :");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter client's age :");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter client's id :");
                    string id = Console.ReadLine();
                    Console.WriteLine("Enter number of days :");
                    int days = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter type of room :");
                    string typeofroom = Console.ReadLine();

                    Client a = new Client(name, age, id, days, typeofroom);
                    manager.AddClient(a);
                }

                else if (n == 2)
                {
                    Console.WriteLine("Enter Client's id :");
                    string id = Console.ReadLine();
                    manager.DeleteClient(id);
                }

                else if (n == 3)
                {
                    Console.WriteLine("Enter Client's id :");
                    string id = Console.ReadLine();
                    manager.Calculate(id);
                }

                else return;
            }
        }
    }
}
