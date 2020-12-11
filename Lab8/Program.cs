using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
using System.Text;

namespace Lab8
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите элементы первого множества (через пробел): ");
        //    string enteredSet = Console.ReadLine();
        //    string[] items = enteredSet.Split(' ');
        //    int[] enteredItems = new int[items.Length];
        //    for (int i = 0; i < items.Length; i++)
        //    {
        //        enteredItems[i] = Convert.ToInt32(items[i]);
        //    }
        //    Set firstSet = new Set(enteredItems);

        //    Console.WriteLine();
        //    Console.WriteLine("Введите элементы второго множества (через пробел): ");
        //    enteredSet = Console.ReadLine();
        //    items = enteredSet.Split(' ');
        //    enteredItems = new int[items.Length];
        //    for (int i = 0; i < items.Length; i++)
        //    {
        //        enteredItems[i] = Convert.ToInt32(items[i]);
        //    }
        //    Set secondSet = new Set(enteredItems);

        //    Console.WriteLine();
        //    bool exit = false;
        //    do
        //    {
        //        Console.Write($"Выберите множество, на основе которого хотите проверить подмножество (0 для пропуска этого условия): ");
        //        int choice = Convert.ToInt32(Console.ReadLine());
        //        switch (choice)
        //        {
        //            case 0:
        //                {
        //                    exit = true;
        //                    break;
        //                }
        //            case 1:
        //                {
        //                    Console.WriteLine($"Первое множество: ");
        //                    firstSet.ShowSet();
        //                    Console.WriteLine($"Проверка на принадлежность подмножества первому множеству\n (Введите элементы подмножества через пробел): ");
        //                    enteredSet = Console.ReadLine();
        //                    items = enteredSet.Split(' ');
        //                    enteredItems = new int[items.Length];
        //                    for (int i = 0; i < items.Length; i++)
        //                    {
        //                        enteredItems[i] = Convert.ToInt32(items[i]);
        //                    }
        //                    Console.WriteLine();
        //                    if (enteredItems > firstSet) Console.WriteLine($"Введённое множество является подмножеством данного множества\n");
        //                    else Console.WriteLine($"Введённое множество не является подмножеством данного множества\n");
        //                    break;
        //                }
        //            case 2:
        //                {
        //                    Console.WriteLine($"Второе множество: ");
        //                    secondSet.ShowSet();
        //                    Console.WriteLine($"Проверка на принадлежность подмножества второму множеству\n (Введите элементы подмножества через пробел): ");
        //                    enteredSet = Console.ReadLine();
        //                    items = enteredSet.Split(' ');
        //                    enteredItems = new int[items.Length];
        //                    for (int i = 0; i < items.Length; i++)
        //                    {
        //                        enteredItems[i] = Convert.ToInt32(items[i]);
        //                    }
        //                    Console.WriteLine();
        //                    if (enteredItems > secondSet) Console.WriteLine($"Введённое множество является подмножеством данного множества\n");
        //                    else Console.WriteLine($"Введённое множество не является подмножеством данного множества\n");
        //                    break;
        //                }
        //        }
        //    } while (!exit);

        //    Console.WriteLine("\nПересечение двух введённых множеств: ");
        //    Set crossedSet = firstSet % secondSet;
        //    crossedSet.ShowSet();

        //    Console.WriteLine("\nРавенство или неравенство двух введённых множеств: : ");
        //    int equalSet = firstSet != secondSet;
        //    if (equalSet == 0)
        //        Console.WriteLine("Множества не равны");
        //    else
        //        Console.WriteLine("Множества равны");

        //    firstSet.SetOwner.ToString();
        //    secondSet.SetDate.ToString();
        //}

        static void Main(string[] args)
        {
            try
            {

                int[] intArray = new int[] { 2, 4, 6, 8, 10 };
                Set<int> intSet = new Set<int>(intArray);
                intSet.LookUp();
                intSet.Delete(2);
                intSet.LookUp();
                intSet.Add(9);
                intSet.Sort();
                intSet.LookUp();
                float[] floatArray = new float[] { 2.8f, 1.9f, 2.2f, 4.2f, 3.3f };
                Set<float> floatSet = new Set<float>(floatArray);
                floatSet.LookUp();
                floatSet.Delete(2);
                floatSet.LookUp();
                floatSet.Add(10);
                floatSet.Sort();
                floatSet.LookUp();
                PrintDevice printObj = new PrintDevice("Canon", 5, "Устройство PIXMA MG2540S «Все в одном» для ежедневной печати, сканирования и копирования.", 760, "Китай");
                Skaner skanObj = new Skaner("Canon CanoScan", 4, "Легкий и компактный планшетный сканер формата A4 со стильным дизайном Canon CanoScan LiDE 300.", 550, "Китай");
                Computer compObj = new Computer("Asus Zenbook", 10, "Креативность, стиль, инновационность – эти качества воплощает новый ZenBook 14.", "AMD Ryzen 5", 1500, "Ультрабук");
                Tablet tablObj = new Tablet("Lenovo M10 Plus", 6, "-", 10.3, 990, "Tab M10 (Lenovo)");
                Product[] prArr = new Product[] { printObj, skanObj, compObj, tablObj };
                Set<Product> prSet = new Set<Product>(prArr);
                prSet.LookUp();
                prSet.Delete(skanObj);
                prSet.LookUp();
                prSet.Add(printObj);
                prSet.Sort();
                prSet.LookUp();
                prSet.ToFile(@"D:\VisualStudio\OOP\Lab8\Set.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}\n{ex.StackTrace}");  
            }
            finally
            {
                Console.WriteLine("End of program");
            }
        }
    }
}

