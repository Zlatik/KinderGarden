using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinderGarden;

namespace Children
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your children group size:");
            int n = int.Parse(Console.ReadLine());
            Child[] arr = new Child[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new Child();
                Console.WriteLine("enter child's name");
                arr[i].Name = Console.ReadLine();
                Console.WriteLine("enter child's surname");
                arr[i].Surname = Console.ReadLine();
                Console.WriteLine("enter child's age");
                arr[i].Age = int.Parse(Console.ReadLine());
                Console.WriteLine("enter child's address");
                arr[i].Address = Console.ReadLine();
                Console.WriteLine("enter child's father");
                arr[i].Father = Console.ReadLine();
                Console.WriteLine("enter child's mother");
                arr[i].Mother = Console.ReadLine();
                Console.WriteLine("enter child's father's phone");
                arr[i].FathersPhone = Console.ReadLine();
                Console.WriteLine("enter child's mother's phone");
                arr[i].MothersPhone = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("enter amount of teachers in your Kindergarden:");
            int z = int.Parse(Console.ReadLine());
            Teacher[] teach = new Teacher[z];
            for (int i = 0; i < z; i++)
            {
                Console.WriteLine("enter teacher's name");
                teach[i].Name = Console.ReadLine();
                Console.WriteLine("enter teacher's surname");
                teach[i].Surname = Console.ReadLine();
                Console.WriteLine("enter teacher's age");
                teach[i].Age = int.Parse(Console.ReadLine());
                Console.WriteLine("enter teacher's address");
                teach[i].Address = Console.ReadLine();
                Console.WriteLine("enter teacher's father");
                teach[i].Father = Console.ReadLine();
                Console.WriteLine("enter teacher's mother");
                teach[i].Mother = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" child's name",arr[i].Name);
               
                Console.WriteLine(" child's surname",arr[i].Surname);
                Console.WriteLine(" child's age", arr[i].Age);
                Console.WriteLine(" child's address",arr[i].Address);
                Console.WriteLine(" child's father",arr[i].Father);
                Console.WriteLine(" child's mother",arr[i].Mother);
                Console.WriteLine(" child's father's phone",arr[i].FathersPhone);
                Console.WriteLine(" child's mother's phone",arr[i].MothersPhone);
                
            }
            for (int i = 0; i < z; i++)
            {
                Console.WriteLine(" teacher's name", teach[i].Name);

                Console.WriteLine(" teacher's surname", teach[i].Surname);
                Console.WriteLine(" teacher's age", teach[i].Age);
                Console.WriteLine(" teacher's address", teach[i].Address);
                Console.WriteLine(" teacher's father", teach[i].Father);
                Console.WriteLine(" teacher's mother", teach[i].Mother);


            }
            Console.ReadKey();
        }
    }
}