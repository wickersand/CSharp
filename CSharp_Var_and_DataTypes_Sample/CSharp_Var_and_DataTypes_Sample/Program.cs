using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_Var_and_DataTypes_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string city;
            sbyte age;
            int pin;

            Console.WriteLine("Enter your name:\n");
            name = Console.ReadLine();

            Console.WriteLine("Enter your City:\n");
            city = Console.ReadLine();

            Console.WriteLine("Enter your Age:\n");
            age = sbyte.Parse(Console.ReadLine());

            Console.WriteLine("Enter your pin:\n");
            pin = Int32.Parse(Console.ReadLine());

            //Mostrando a mensagem na tela
            Console.WriteLine("=================");
            Console.WriteLine("Your complete Address: ");
            Console.WriteLine("=================\n");

            Console.WriteLine("Name = {0}", name);
            Console.WriteLine("City = {0}", city);
            Console.WriteLine("Age = {0}", age);
            Console.WriteLine("Pin = {0}", pin);
            Console.WriteLine("=================\n");

            Console.ReadLine();
        }
    }
}
