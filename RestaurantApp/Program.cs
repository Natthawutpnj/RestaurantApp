using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO TIT.1/1");
        }
    }
    public class Restaurant
    {
        private int UID { get; set; }
        private string _name { get; set; }
        private string _type { get; set; }
        private double _score { get; set; }

        public Restaurant(int uid,string _name,string _type,double _score)
        {
            this.UID = uid;
            this ._name = _name;
            this ._type = _type;
            this ._score = _score;
        }
    }
}
