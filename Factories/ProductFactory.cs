using ManagerApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerApp.Factories
{
    public abstract class ProductFactory
    {
        public static Product Produce(string productLine) 
        {
            return productLine switch
            {
                "Meat" => new Meat(),
                "Milk" => new Milk(),
                "Egg" => new Egg(),
            };
        }
    }
}
