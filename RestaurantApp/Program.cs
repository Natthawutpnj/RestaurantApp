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
            List<Restaurant> restaurants = new List<Restaurant>
{
    new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
    new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
    new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
    new Restaurant(4, "Huguosi Snacks", "Snacks", 4.2),
    new Restaurant(5, "Haidilao Hot Pot", "Hot Pot", 4.8)

            };
            foreach (var item in restaurants)
            {
                Console.WriteLine($"{item.UID}. {item._name} ({item._type}) - Rating: {item._score}");
            }
            var amount = restaurants.Count();
            var avg = restaurants.Average(x => x._score);
            Console.WriteLine($"Total is {amount}");
            Console.WriteLine($"Average is {amount} ({avg})");

            
        }
    }
    public class Restaurant
    {
        public int UID { get; set; }
        public string _name { get; set; }
        public string _type { get; set; }
        public double _score { get; set; }

        public Restaurant(int uid,string _name,string _type,double _score)
        {
            this.UID = uid;
            this ._name = _name;
            this ._type = _type;
            this ._score = _score;
        }
    }
}
