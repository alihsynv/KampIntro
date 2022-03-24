using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, float, enum, boolean  --  value types
            int number1 = 10;
            int number2 = 20;

            number1 = number2;
            number2 = 100;

            //Console.WriteLine(number1);


            // arrays, class, interface....  --  reference types
            int[] numbers1 = new int[] { 1, 2, 3 };
            int[] numbers2 = new int[] { 10, 20, 30 };

            numbers1 = numbers2;
            numbers2[0] = 1000;

            //Console.WriteLine(numbers1[0]);



            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Ali";

            person2 = person1;
            person1.FirstName = "Huseyn";

            //Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Salih";

            Employee employee = new Employee();
            employee.FirstName = "Ahmet";

            Person person3 = customer;
            //Console.WriteLine(person3.FirstName);


            PersonManeger personManeger = new PersonManeger();
            personManeger.Add(customer);

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManeger
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
