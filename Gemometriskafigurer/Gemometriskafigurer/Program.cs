﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemometriskafigurer
{
    public enum ShapeType { Rectangle, Ellipse };

    class Program
    {
        static void Main(string[] args) //Anropa viewmenu. Ej avsluta ->Createchape anropas
        {
            bool exit = false;

            do
            {
                ViewMenu(); //kallar på menyn
                  
                switch (Console.ReadLine())
                {
                    case "0":
                        exit = true;
                        continue;

                    case "1":
                        CreateShape(ShapeType.Rectangle); //skickar med rectangle till createshape
                        break;

                    case "2":
                        CreateShape(ShapeType.Ellipse);
                        break;  
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("FEL! Välj ett flyttal mellan 0-2.");
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("\n   Tryck tangent för att prova igen   ");
                        Console.ResetColor();
                        Console.CursorVisible = false;
                        Console.ReadKey(true);
                        Console.Clear();
                        Console.CursorVisible = true;
                    continue;

                }
                    
                }while (!exit);

              
                
             }


        private static Shape CreateShape(ShapeType shapeType) //läser in objektets längd och bredd
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ╔═══════════════════════════════════╗ ");
            Console.WriteLine(" ║            {0,10}             ║ ",shapeType);
            Console.WriteLine(" ╚═══════════════════════════════════╝ ");
            Console.ResetColor();
            double width = ReadDoubleGraterThanZero("Skriv in bredden:"); //anropar ReadGreaterThanZero med en string, där kollar den metoden så att värderna stämmer
            double length = ReadDoubleGraterThanZero("Skriv in längden:");

            switch (shapeType)
            {
                case ShapeType.Rectangle:
                    return new Rectangle(length, width);

                case ShapeType.Ellipse:
                    return new Ellipse(length, width);

                default:
                    throw new NotImplementedException();
            }


        }

        private static double ReadDoubleGraterThanZero(string prompt)
        {
            //int value = 0;
            //string input = Console.ReadLine();
            //try
            //{
            //    value = int.Parse(input);
            //    if(value<=0)
            //    {
            //        throw new OverflowException();
            //    }
            //    break;
            //}
            //catch(FormatException)
            //{
            //    Console.WriteLine("FEL! {0} kan inte tolkas som ett heltal", input);
            //}

            int input;

            do
            {
                Console.WriteLine(prompt);
                if (int.TryParse(Console.ReadLine(), out input) && input > 0)
                {
                    return input;
                }

            } while (true);
            Console.WriteLine("Tyvärr, ditt tal måste vara större än 0.");
        }

        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ╔═══════════════════════════════════╗ ");
            Console.WriteLine(" ║          Choose a form            ║ ");
            Console.WriteLine(" ╚═══════════════════════════════════╝ ");
            Console.ResetColor();
            Console.WriteLine(" 0. Exit.");
            Console.WriteLine(" 1. Rectangle.");
            Console.WriteLine(" 2. Ellipse.");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n  ════════════════════════════════════ \n");
            Console.ResetColor();
            Console.Write(" Ange menyval [0-2]: ");
            
        }

        private void ViewShapeDetail(Shape shape)
        {
            Console.WriteLine();

        }
    }
}
