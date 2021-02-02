using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clone üzerinden gider ve performans anlamında iyidir
            Customer customer1 = new Customer { FirstName = "Emircan", LastName = "Dalman", City = "Giresun", Id = 1 };
            Console.WriteLine(customer1.FirstName);

            Customer customer2 = (Customer)customer1.Clone();
            customer2.FirstName = "Ali";
            customer2.LastName = "Dalman";
            customer2.City = "Giresun";
            customer2.Id = 2;
            Console.WriteLine(customer2.FirstName);
        }
    }

    public abstract class Person
    {
        public abstract Person Clone();
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Customer : Person
    {
        public string City { get; set; }
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
    public class Employee : Person
    {
        public decimal Salary { get; set; }
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
