using System;
using System.Linq;
using System.Collections.Generic;

namespace Shopping_Spree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();
            string[] personsInfo = Console.ReadLine().Split(';');
            for (int i = 0; i < personsInfo.Length; i++)
            {
                string[] personInformation = personsInfo[i].Split('=');
                string name = personInformation[0];
                decimal money = decimal.Parse(personInformation[1]);
                Person currentPerson = new Person(name, money);
                persons.Add(currentPerson);
            }
            string[] productsInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < productsInfo.Length; i++)
            {
                string[] productInfo = productsInfo[i].Split('=');
                string productName = productInfo[0];
                decimal productPrice = decimal.Parse(productInfo[1]);
                Product currentProduct = new Product(productName, productPrice);
                products.Add(currentProduct);
            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] tokens = command.Split(" ");
                string name=tokens[0];
                string productinfo=tokens[1];
                Person findPerson = persons.FirstOrDefault(person => person.Name == name);
                Product findProduct = products.FirstOrDefault(product => product.Name==productinfo);
                if (findPerson.Money >= findProduct.Price)
                {
                    findPerson.AddProductToTheBag(findProduct.Name);
                    Console.WriteLine($"{findPerson.Name} bought {findProduct.Name}");
                    findPerson.Money -= findProduct.Price;
                }
                else
                {
                    Console.WriteLine($"{findPerson.Name} can't afford {findProduct.Name}");
                }
            }
            PrintOutput(persons);

        }

        private static void PrintOutput(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                if (person.Bag.Count>0)
                {
                        Console.WriteLine($"{person.Name} - {string.Join(", ", person.Bag)}");             
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
    class Person
    {
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            Bag = new List<string>();
        }
        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<string> Bag { get; set; }
        public void AddProductToTheBag(string prodcut)
        {
            this.Bag.Add(prodcut);
        }
    }
    class Product
    {
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }

    }
}
