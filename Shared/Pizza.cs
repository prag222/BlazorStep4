using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStep4.Shared
{
    public class Pizza
    {
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public Spiciness Spiciness { get; }
        public Pizza(int id,string name,decimal price,Spiciness spiciness)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Spiciness = spiciness;
        }
    }
}
