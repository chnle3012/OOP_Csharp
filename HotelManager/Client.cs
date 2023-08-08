using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager
{
    public class Client
    {
        private string name;
        private int age;
        private string id;
        private int days;
        private string typeofroom;

        public Client(string name, int age, string id, int days, string typeofroom)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.days = days;
            this.typeofroom = typeofroom;
        }

        public string getId()
        {
            return this.id;
        }
        public int getDays()
        {
            return this.days;
        }
        public string getTypeofroom()
        {
            return this.typeofroom;
        }
    }
}
