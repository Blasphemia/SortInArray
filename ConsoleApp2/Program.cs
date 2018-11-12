using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of lines in the array: ");
            int lines = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of columns in the array: ");
            int columns = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter min number for random generation:");
            int min = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter max number for random generation:");
            int max = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n");



            int[,] bubaArray = new int[lines, columns];
            var rnd = new Random();

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    bubaArray[i, j] = rnd.Next(min, max + 1);
                    Console.Write("{0}\t", bubaArray[i, j]);
                }
                Console.WriteLine("\n");
            }


            Console.WriteLine("\n Bubble Sort \n ");

            BubbleSort(bubaArray, lines, columns);






               

            Console.ReadLine();
        }



        static void BubbleSort(int[,] bubaArray, int lines, int columns)
        {
            int[] tempArray = new int[lines * columns];
            int kostyl = 0;
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    tempArray[kostyl] = bubaArray[i, j];


                    kostyl++;
                }
            }

            Console.Write("\n");

            for (int i = 0; i < tempArray.Length; i++)
            {
                for (int j = 0; j < tempArray.Length - 1; j++)
                {
                    if (tempArray[j] > tempArray[j + 1])
                    {
                        kostyl = tempArray[j];
                        tempArray[j] = tempArray[j + 1];
                        tempArray[j + 1] = kostyl;

                    }
                }
            }
            Console.Write("\n");
            kostyl = 0;
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    bubaArray[i, j] = tempArray[kostyl];
                    kostyl++;
                    Console.Write("{0}\t", bubaArray[i, j]);
                }
                Console.WriteLine("\n");
            }





        }





    }
}