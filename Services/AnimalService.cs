using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerApp.Entities;
using ManagerApp.Interfaces;
using ManagerApp.Stores;

namespace ManagerApp.Services
{
    internal class AnimalService : IAnimalService
    {
        //private readonly List<IAnimal> _animals = new List<IAnimal>();

        private readonly Store _store;

        public AnimalService()
        {
            _store = new Store();
        }

        public void AddAnimal(IAnimal animal)
        {
            _store.AnimalList.Add((Animal)animal);
        }


        public void RemoveAnimal(int id)
        {
            var animal = GetAnimalById(id);
            if (animal != null)
            {
                _store.AnimalList.Remove((Animal)animal);
            }
        }

        public IAnimal GetAnimalById(int id)
        {
            return _store.AnimalList.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<IAnimal> GetAllAnimals()
        {
            return _store.AnimalList;
        }
    }
}
