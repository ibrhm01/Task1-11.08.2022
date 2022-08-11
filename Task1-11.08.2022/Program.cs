using System;
using Task1_11._08._2022.Models;

namespace Task1_11._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            User a = new User(Console.ReadLine(), Console.ReadLine());
            
            Console.WriteLine($"Username:{a.UserName}\nPassword:{a.Password}");
        }
    }
}
