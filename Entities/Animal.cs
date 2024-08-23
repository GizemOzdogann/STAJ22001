using ManagerApp.Factories;
using ManagerApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerApp.Entities
{
    public class Animal : IAnimal
    {
        public int Id { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }
    }

    public class Cow : Animal {}
    public class Chicken : Animal {}
    public class Sheep : Animal {}

}