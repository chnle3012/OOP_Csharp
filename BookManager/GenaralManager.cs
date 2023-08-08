using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    public class GenaralManager
    {
        List<Book> books = new List<Book>();
        List<Magazine> magazines = new List<Magazine>();
        List<News> news = new List<News>();

        // Chuc nang them tai lieu
        public void AddBooks(Book a)
        {
            books.Add(a);
        }
        public void AddMagazines(Magazine a)
        {
            magazines.Add(a);
        }
        public void AddNew(News a)
        {
            news.Add(a);
        } 
        
        // Chuc nang xoa tai lieu theo ma
        public void Delete(string id)
        {
            foreach(Book book in books)
            {
                if(book.getId() == id)
                {
                    books.Remove(book);
                    break;
                }
            }
            foreach (Magazine magazine in magazines)
            {
                if (magazine.getId() == id)
                {
                    magazines.Remove(magazine);
                    break;
                }
            }
            foreach (News newss in news)
            {
                if (newss.getId() == id)
                {
                    news.Remove(newss);
                    break;
                }
            }
        }

        // Chuc nang hien thi thog tin tai lieu
        public void Display()
        {
            foreach (Book book in books)
            {
                Console.Write("Book - ");
                Console.WriteLine(book.getId() + " " + book.getPublisher() + " " + book.getQuantity() + " " + book.getAuthor() + " " + book.getPage());
            }
            foreach (Magazine magazine in magazines)
            {
                Console.Write("Magazine - ");
                Console.WriteLine(magazine.getId() + " " + magazine.getPublisher() + " " + magazine.getQuantity() + " " + magazine.getPublishId() + " " + magazine.getMonDate());
            }
            foreach (News newss in news)
            {
                Console.Write("Newspaper - ");
                Console.WriteLine(newss.getId() + " " + newss.getPublisher() + " " + newss.getQuantity() + " " + newss.getDayDate());
            }
        }

        // Chuc nang tim kiem tai lieu theo loai
        public void BookSearching()
        {
            foreach (Book book in books)
            {
                Console.Write("Book - ");
                Console.WriteLine(book.getId() + " " + book.getPublisher() + " " + book.getQuantity() + " " + book.getAuthor() + " " + book.getPage());
            }
        }
        public void MagazineSearching()
        {
            foreach (Magazine magazine in magazines)
            {
                Console.Write("Magazine - ");
                Console.WriteLine(magazine.getId() + " " + magazine.getPublisher() + " " + magazine.getQuantity() + " " + magazine.getPublishId() + " " + magazine.getMonDate());
            }
        }
        public void Newssearching()
        {
            foreach (News newss in news)
            {
                Console.Write("Newspaper - ");
                Console.WriteLine(newss.getId() + " " + newss.getPublisher() + " " + newss.getQuantity() + " " + newss.getDayDate());
            }
        }
    }
}
