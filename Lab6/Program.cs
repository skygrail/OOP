using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDevice printObj = new PrintDevice("", 5, "", "");
            Skaner skanObj = new Skaner("", 4, "", "");
            Computer compObj = new Computer("", 10, "", "", 1500, "");
            Tablet tablObj = new Tablet("", 6, "", 1144, 990, "");

            compObj.Available();
            skanObj.Available();
            printObj.priceIncrease();

            Console.WriteLine(new string('=', 35));
            Console.WriteLine("Информация о имеющемся планшете: ");
            Console.WriteLine(tablObj.ToString());

            Console.WriteLine(new string('=', 35));
            Product prodObj = new Computer("", 3, "", "", 2200, "");
            Console.WriteLine("Информация о новом товаре:");
            Console.WriteLine(prodObj.ToString());

            Console.WriteLine(new string('=', 35));
            Console.WriteLine(prodObj is Product ? "Объект prodObj является элементом класса Product" : "Объект prodObj не является элементом класса Product");
            Console.WriteLine(compObj is Device ? "Объект compObj является элементом класса Device" : "Объект compObj не является элементом класса Device");
            Console.WriteLine(tablObj is Skaner ? "Объект tablObj является элементом класса Device" : "Объект tablObj не является элементом класса Device");

            Console.WriteLine(new string('=', 35));
            var secProd = prodObj as Computer;
            if (secProd != null)
                Console.WriteLine(secProd.ToString());

            Console.WriteLine(new string('=', 35));
            compObj.Producer();
            compObj.GetDiscounts();
            tablObj.InfoAboutDiscounts();

            Console.WriteLine(new string('=', 35));
            Console.WriteLine("Вызываем класс IPrinter и метод IAmPrinting(): ");
            IPrinter printing = new IPrinter();
            Product[] ArrayTech = new Product[] { printObj, skanObj, tablObj };
            foreach (var tech in ArrayTech)
            {
                printing.IAmPrinting(tech);
                Console.WriteLine();
            }
        }
    }
}
