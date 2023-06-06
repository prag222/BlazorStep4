using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStep4.Shared
{
    public class Menu
    {
        public List<Pizza> Pizzas=new List<Pizza>();
        public void Add(Pizza pizza)=>Pizzas.Add(pizza);

        public Pizza? GetPizza(int id) => Pizzas.FirstOrDefault(x => x.Id == id);
    }
}
