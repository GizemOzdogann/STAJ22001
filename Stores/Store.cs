using ManagerApp.Entities;
using ManagerApp.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerApp.Stores
{
    public class Store
    {
        private static Store? _instance;
        private static readonly object _lock = new object();

        private List<Animal> _animalList = new List<Animal>();
        private List<Product> _productList = new List<Product>();

        public static Store Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Store();
                    }
                    return _instance;
                }
            }
        }

        public List<Animal> AnimalList => _animalList; 
        public List<Product> ProductList => _productList;

        public void AddAnimal(Animal animal)
        {
            _animalList.Add(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            _animalList.Remove(animal);
        }

        public List<Animal> GetAnimals()
        {
            return _animalList;
        }

        public void AddProduct(Product product)
        {
            _productList.Add(product);
        }

        public List<Product> GetProducts()
        {
            return _productList;
        }
    }
}
