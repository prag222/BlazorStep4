using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStep4.Shared
{
    public class State
    {
        public Menu Menu { get; set; } = new Menu();
        public ShoppingBasket Basket { get; set; }=new ShoppingBasket();    
        public UI UI { get; set; }=new UI();
    }
}
