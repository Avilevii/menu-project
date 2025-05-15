// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;


namespace MyApp
{
    
    class Program
    {



        static void Main(string[] args)
        {
            List<int> series = new List<int>();
            
            if (args.Length >= 3)
            {
                foreach (var arg in args)
                {
                    if (int.TryParse(arg, out int number) && number > 0)
                    {
                        series.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("הוזן קלט שגוי. נבקש להזין מחדש.");
                        return;
                    }
                }
            }
            else
            {
                series = ReplaceSeries();

            }

            ShowMenu(series);
            
        }




       
        static void ShowMenu( List<int> series)
        {

            int chois = 0;

            while (chois != 10)
            {

                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Enter a new series");
                Console.WriteLine("2. Display the series in original order");
                Console.WriteLine("3. Display the series in reverse order");
                Console.WriteLine("4. Display the sorted series (ascending)");
                Console.WriteLine("5. Show the maximum value in the series");
                Console.WriteLine("6. Show the minimum value in the series");
                Console.WriteLine("7. Show the average of the series");
                Console.WriteLine("8. Show the number of elements in the series");
                Console.WriteLine("9. Show the sum of the series");
                Console.WriteLine("10. Exit");

                int user = Convert.ToInt32(Console.ReadLine());
           
                switch (user)
                {
                    case 1:
                        series.Clear();
                        series.AddRange(ReplaceSeries());
                        break;

                    case 2:
                        printUser(series);
                        break;

                    case 3:
                        countdown(series);
                        break;

                    case 4:
                        PrintSorting(series);
                        break;

                    case 5:
                        maxNum(series);
                        break;

                    case 6:
                        minNum(series);
                        break;

                    case 7:
                        average(series);
                        break;
                    case 8:
                        elements(series);
                        break;
                    case 9:
                        sum(series);
                        break;
                    case 10:
                        exit();
                        chois = 10;
                        break;

                }

            }



        }

        static List<int> ReplaceSeries()
        {
         List<int> numbers = new List<int>();
            bool valiInput = false;
            while (!valiInput)
            {
                numbers.Clear();
                Console.WriteLine("Enter at least 3 positive numbers separated by spaces:");

                string input = Console.ReadLine();
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (string part in parts)
                {
                    if (int.TryParse(part, out int number) && number > 0)
                    {
                        numbers.Add(number);

                    }
                    else
                    {
                        Console.WriteLine("You must enter digits!");
                    }

                }
                if (numbers.Count >= 3)
                {
                    valiInput = true;
                }
                else
                {
                    Console.WriteLine("you mast min 3 series");
                }
            
            }
            return numbers;




            
        }

        static void printUser(List<int> series)
        {
         foreach(int number in series)
            {
                Console.Write($"{ number}, ");
            }
        }

        static void countdown(List<int> series)
        {
            for (int i = series.Count - 1; i >= 0; i--)
            {
                Console.Write(series[i] + " ");
            }
            
        }

        static void PrintSorting(List<int> series)
        {
            series.Sort();
            foreach (int num in series)
            {
                Console.WriteLine(num);
            }


            
        }

        static void maxNum(List<int> series)
        {
            Console.WriteLine($"the max num is:{series.Max()}");
        }


        static void minNum(List<int> series)
        {
            Console.WriteLine($"the num min is {series.Min()}");

        }

        static void average(List<int> series)
        {
         float count = series.Count;
            float sum = 0; 
            
            foreach (int num in series)
            {
             sum += num;
            }
            float avg =  sum / count;
            Console.WriteLine($"averag is {avg:F2}");
        
        }

        static void elements(List<int> series)
        {
            Console.WriteLine($"num of aelments is {series.Count()}");

        }












        static void sum(List<int> series)
        {
            int sum = 0;
            foreach(int num in series)
            {
                sum += num;
            }

            Console.WriteLine($"the sum of numbers is {sum}");
        
        }


        static void exit()
        {
            Console.WriteLine("The program is over!");
        }


     




    }
}

