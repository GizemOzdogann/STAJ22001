using ManagerApp.Entities;
using ManagerApp.Interfaces;
using ManagerApp.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerApp.Factories
{
    public abstract class AnimalFactory 
    {
        public abstract Animal CreateAnimal();

        public static AnimalFactory GetFactory(string animalType)
        {
            return animalType switch
            {
                "Cow" => new CowFactory(),
                "Chicken" => new ChickenFactory(),
                "Sheep" => new SheepFactory(),
            };
        }
    }

    public class CowFactory : AnimalFactory
    {
        public override Animal CreateAnimal()
        {
            return new Cow();
        }
    }

    public class ChickenFactory : AnimalFactory
    {
        public override Animal CreateAnimal()
        {
            return new Chicken();
        }
    }

    public class SheepFactory : AnimalFactory
    {
        public override Animal CreateAnimal()
        {
            return new Sheep();
        }
    }
    
}