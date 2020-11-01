using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    partial class Controller
    {
        //Может быть ещё.. Добавьте в класс-контроллер метод, считывающий построчно
        //текстовый файл, в котором хранятся данные вашего класса и инициализирует
        //таким образом коллекцию.
        public static Product ReadFromFile(List<Product> products)
        {
            int counter = 1;
            string line, line1 = " ",  line3 = " ", line4 = " ",  line6 = " ";
            int line2 = 0, line5 = 0;
      
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"D:\VisualStudio\OOP\Lab6\new_tech.txt");
            while ((line = file.ReadLine()) != null)
            {
                //Console.WriteLine(line);
                switch (counter)
                {
                    case 1:
                        {
                            line1 = line;
                        }
                        break;
                    case 2:
                        {
                            line2 = Convert.ToInt32(line);
                        }
                        break;
                    case 3:
                        {
                            line3 = line;
                        }
                        break;
                    case 4:
                        {
                            line4 = line;
                        }
                        break;
                    case 5:
                        {
                            line5 = Convert.ToInt32(line);
                        }
                        break;
                    case 6:
                        {
                            line6 = line;
                        }
                        break;
                }

                counter++;
            }
            Computer compObjFromFile = new Computer(line1, line2, line3, line4, line5, line6);
            file.Close();
            return compObjFromFile;


        }
    }
}
