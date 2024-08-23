using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerApp.Interfaces
{
    public interface IAnimal
    {
        public int Id { get; set; }
        public string Gender { get; set; }
        int Age { get; set; }
    }

    public enum Gender
    {
        Female,
        Male
    }
}
