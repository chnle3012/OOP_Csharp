using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager
{
    public class Manager
    {
        List<Client> clients = new List<Client>();
        // Them moi khach hang
        public void AddClient(Client a)
        {
            clients.Add(a);
        }

        // Xoa khach hang
        public void DeleteClient(string id)
        {
            foreach(Client a in clients)
            {
                if(a.getId() == id)
                {
                    clients.Remove(a);
                    break;
                }
            }
        }

        // Tinh tien
        public void Calculate(string id)
        {
            foreach( Client i in clients)
            {
                if(i.getId() == id)
                {
                    int days = i.getDays();
                    string typeofroom = i.getTypeofroom();

                    int price;
                    if(typeofroom == "A")
                    {
                        price = days * Hotel.Aroom;
                    }
                    else if(typeofroom == "B")
                    {
                        price = days * Hotel.Broom;
                    }
                    else
                    {
                        price = days * Hotel.Croom;
                    }
                    Console.WriteLine("Total price : " + price);
                    break;
                }
            }

        }
    }
}
