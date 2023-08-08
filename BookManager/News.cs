using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    public class News : Doccument
    {
        private string dayDate;
        public News(string id, string publisher, int quantity, string dayDate) : base(id, publisher, quantity)
        {
            this.dayDate = dayDate;
        }

        public string getDayDate()
        {
            return this.dayDate;
        }
    }
}
