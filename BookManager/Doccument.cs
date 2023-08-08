using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    public class Doccument
    {
        private string id;
        private string publisher;
        private int quantity;

        public Doccument(string id, string publisher, int quantity)
        {
            this.id = id;
            this.publisher = publisher;
            this.quantity = quantity;
        }

        public string getId()
        {
            return this.id;
        }
        public string getPublisher()
        {
            return this.publisher;
        }
        public int getQuantity()
        {
            return this.quantity;
        }
    }
}
