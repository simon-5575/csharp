// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp
    {
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadaj prve cislo");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("yadaj znamienko");
            string operation = Console.ReadLine();
            
             
            Console.WriteLine("zadajte druhe cislo");
             double number2 = double.Parse(Console.ReadLine());

            switch (operation)
            {

                case "+":
                    Console.WriteLine(number1 + number2);
                    break;

                case "-":
                    Console.WriteLine(number1 - number2);
                    break;

                case "*":
                    Console.WriteLine(number1 * number2);
                    break;

                case "/":
                    Console.WriteLine(number1 / number2);
                    break;

                default: Console.WriteLine("nespravny operator");
                    break;



            }
        }   
        }
    }







