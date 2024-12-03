using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program(); // Khởi tạo đối tượng Program
            program.Option(); 

            
        }

        public void Option()
        {
            bool exit = false;
            Person[] persons = new Person[0]; // Mảng person ban đầu trống

            while (!exit)
            {
                // Hiển thị menu
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Enter person information");
                Console.WriteLine("2. Display person information");
                Console.WriteLine("3. Sort persons by salary");
                Console.WriteLine("4. Exit");
                Console.Write("Please choose an option (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Nhập thông tin cho người
                        Console.Write("Enter number of persons: ");
                        int n = int.Parse(Console.ReadLine());
                        persons = new Person[n]; // Khởi tạo lại mảng với kích thước n

                        for (int i = 0; i < n; i++) // Nhập thông tin cho từng person
                        {
                            Console.WriteLine($"Person {i + 1}: ");
                            Person p = new Person();
                            persons[i] = p.inputPersonInfor(); // Gọi phương thức nhập thông tin
                        }
                        break;

                    case "2":
                        // Hiển thị thông tin của tất cả người
                        Console.WriteLine("\nDisplaying Person Information:\n");
                        foreach (var person in persons)
                        {
                            Person.dispalyPersonInfor(person); // Hiển thị thông tin từng person
                            Console.WriteLine(); // Thêm dòng trống giữa các thông tin người
                        }
                        break;

                    case "3":
                        // Sắp xếp mảng người theo lương
                        if (persons.Length > 0)
                        {
                            foreach (var pe in persons)
                            {
                                Person.SortBySalary(persons);
                                Person.dispalyPersonInfor(pe);
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No persons to sort.");
                        }
                        break;

                    case "4":
                        // Thoát chương trình
                        exit = true;
                        Console.WriteLine("Exiting program.");
                        break;

                    default:
                        Console.WriteLine("Invalid option, please choose again.");
                        break;
                }

                // Đợi người dùng nhấn phím để quay lại menu
                if (!exit)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

    }
}
