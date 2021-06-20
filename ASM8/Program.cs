using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            Member member = new Member();
            do
            {
                Console.Write("Enter member name: ");
                string name = Console.ReadLine();
                if (name.Length >= 6 && name.Length <= 40)
                {
                    member.FullName = name;
                    break;
                }
                else
                {
                    Console.WriteLine("Name must have >= 6 characters and <= 40");
                }
            } while (true);
            do
            {
                try
                {
                    Console.Write("Enter age of member: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age >= 6)
                    {
                        member.Age = age;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Member age must be equal or greater than 6!");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);
            do
            {
                Console.Write("Enter member city: ");
                string city = Console.ReadLine();
                if (city.Length >= 4)
                {
                    member.City = city;
                    break;
                }
                else
                {
                    Console.WriteLine("City name must have at least 4 characters !");
                }
            } while (true);
            Console.WriteLine("Select your profession: ");
            DisplayProfessions();
            int choice;
            do
            {
                do
                {
                    Console.Write("Enter your choice: ");
                } while (!int.TryParse(Console.ReadLine(), out choice));
                switch (choice)
                {
                    case 1:
                        member.SetJob("Student");
                        break;
                    case 2:
                        member.SetJob("Teacher");
                        break;
                    case 3:
                        member.SetJob("Retired");
                        break;
                    case 4:
                        member.SetJob("Others");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } while (choice < 1 && choice > 4);
            Console.WriteLine("Name\t\t\tAge\t\tCity\t\tProfession\t\tMembership Fee\n" +
                              "----\t\t\t---\t\t----\t\t----------\t\t--------------");
            Console.WriteLine($"{member.FullName}\t\t{member.Age}\t\t{member.City}\t\t{member.GetJob()}\t\t{member.GetFee()} $");
        }
        static void DisplayProfessions()
        {
            Console.WriteLine("1. Student");
            Console.WriteLine("2. Teacher");
            Console.WriteLine("3. Retired");
            Console.WriteLine("4. Others");
        }


        //Ex2
        Novel novel = new Novel(2);
        novel[0] = new Book("100 - 123 - 456", "Harry Potter", 101);
        novel[1] = new Book("110 - 133 - 567", "Sherlock Holmes", 201);
        Console.WriteLine("CATEGORY: NOVEL");
            novel.DisplayInfor();

            Console.ReadKey();
    }
}

