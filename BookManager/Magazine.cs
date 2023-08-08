using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    public class Magazine : Doccument
    {
        private string publishId;
        private string monDate;

        public Magazine(string id, string publisher, int quantity, string publishId, string monDate) : base(id, publisher, quantity)
        {
            this.publishId = publishId;
            this.monDate = monDate;
        }

        public string getPublishId()
        {
            return this.publishId;
        }
        public string getMonDate()
        {
            return this.monDate;
        }
    }
}
