using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerApp.Interfaces
{
    public interface IAnimalService
    {
        void AddAnimal(IAnimal animal);
        
        void RemoveAnimal(int id);
        IAnimal GetAnimalById(int id);
        IEnumerable<IAnimal> GetAllAnimals();
    }
}
