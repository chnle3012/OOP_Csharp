
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenaralManager genaralManager = new GenaralManager();

            while (true)
            {
                Console.WriteLine("Select number :");
                Console.WriteLine("1. Add new doccument");
                Console.WriteLine("2. Delete doccument");
                Console.WriteLine("3. Display doccument");
                Console.WriteLine("4. Search doccument");
                Console.WriteLine("5. Exit");

                int n = int.Parse(Console.ReadLine());

                if(n == 1)
                {
                    Console.WriteLine("Select doccument :");
                    Console.WriteLine("1. Book");
                    Console.WriteLine("2. Magazine");
                    Console.WriteLine("3. Newspaper");

                    int n1 = int.Parse(Console.ReadLine());

                    if(n1 == 1)
                    {
                        Console.WriteLine("Enter doccument's id :");
                        string id = Console.ReadLine();
                        Console.WriteLine("Enter doccument's publisher :");
                        string publisher = Console.ReadLine();
                        Console.WriteLine("Enter doccument's quantity");
                        int quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter doccument's author");
                        string author = Console.ReadLine();
                        Console.WriteLine("Enter doccument's pages");
                        int pages = int.Parse(Console.ReadLine());

                        Book a = new Book(id, publisher, quantity, author, pages);
                        genaralManager.AddBooks(a);
                    }
                    else if(n1 == 2)
                    {
                        Console.WriteLine("Enter doccument's id :");
                        string id = Console.ReadLine();
                        Console.WriteLine("Enter doccument's publisher :");
                        string publisher = Console.ReadLine();
                        Console.WriteLine("Enter doccument's quantity :");
                        int quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter doccument's publish id :");
                        string publishId = Console.ReadLine();
                        Console.WriteLine("Enter doccument's month date :");
                        string monDate = Console.ReadLine();

                        Magazine a = new Magazine(id, publisher, quantity, publishId, monDate);
                        genaralManager.AddMagazines(a);
                    }
                    else if (n1 == 3)
                    {
                        Console.WriteLine("Enter doccument's id :");
                        string id = Console.ReadLine();
                        Console.WriteLine("Enter doccument's publisher :");
                        string publisher = Console.ReadLine();
                        Console.WriteLine("Enter doccument's quantity :");
                        int quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter doccument's day date :");
                        string dayDate = Console.ReadLine();

                        News a = new News(id, publisher, quantity, dayDate);
                        genaralManager.AddNew(a);
                    }
                }

                else if(n == 2)
                {
                    Console.WriteLine("Enter id :");
                    string id = Console.ReadLine();
                    genaralManager.Delete(id);
                }

                else if(n == 3)
                {
                    Console.WriteLine("Doccument's information :");
                    genaralManager.Display();
                }

                else if(n == 4)
                {
                    Console.WriteLine("Doccument Searching :");
                    Console.WriteLine("1. Book");
                    Console.WriteLine("2. Magazine");
                    Console.WriteLine("3. Newspaper");

                    int n2 = int.Parse(Console.ReadLine());

                    if(n2 == 1)
                    {
                        genaralManager.BookSearching();
                    }
                    else if(n2 == 2)
                    {
                        genaralManager.MagazineSearching();
                    }
                    else
                    {
                        genaralManager.Newssearching();
                    }
                }

                else
                {
                    return;
                }
            }
        }
    }
}
