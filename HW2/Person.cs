using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hw2
{
    internal class Person
    {
        private string name { get; set; }
        private string address { get; set; }
        private double salary { get; set; }

        public Person() : this("", "", 0.0) { }
        public Person(string name, string address, double salary)
        {
            this.name = name;
            this.address = address;
            this.salary = salary;
        }

        public Person inputPersonInfor()//Enter information from user
        {
            while (true)
            {
                Console.Write("Name: ");
                name= Console.ReadLine();
                if (name != "")
                    break;              
            }
            while (true)
            {
                Console.Write("Address: ");
                address = Console.ReadLine();
                if (address != "")
                    break;
            }
            while (true)
            {
                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine());
                if (!double.TryParse(salary.ToString(), out double parsedSalary))//Check salary is valid or not 
                {                               
                    Console.WriteLine($"'{salary}' is not valid. Enter again:");        
                }
                if(salary <0)
                {
                    Console.WriteLine("Salary must be a positive number");
                }
                else
                {
                    this.salary = parsedSalary;
                    break;
                }
            }

            return new Person(name, address, salary);
        }

        public static void dispalyPersonInfor(Person person)
        {
            Console.WriteLine($"{person.name} - {person.address} - {person.salary}");
        }

        public static Person[] SortBySalary(Person[] persons)//Short person 
        {
            int n = persons.Length;
            if (n < 0)
                Console.WriteLine("Can't sort Person");

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (persons[j].salary > persons[j + 1].salary)
                    {
                        // Hoán đổi hai phần tử nếu lương của phần tử trước lớn hơn phần tử sau
                        Person temp = persons[j];
                        persons[j] = persons[j + 1];
                        persons[j + 1] = temp;
                    }
                }
            }
            return persons;
        }
    } 
   
}
