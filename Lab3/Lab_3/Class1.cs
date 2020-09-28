using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Channels;

namespace Lab_3
{
    partial class Abiturient {
        public void RefAndOut(out int abiturAge, ref int houseNum)
        {
            Console.WriteLine("Введите возраст клиента");
            abiturAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер дома клиента");
            houseNum = int.Parse(Console.ReadLine());
        }


        static Abiturient()  //статический конструктор
        {
            Console.WriteLine("Вызван статический конструктор!");
        }

        public Abiturient()
        {
            surname = "";
            firstName = "";
            middleName = "";
            addres = "";
            telNumber = 1;
            marks[0] = 1;
            marks[1] = 1;
            marks[2] = 1;
            marks[3] = 1;


        }

        public override string ToString()
        {
            return "Something break";
        }

        public override bool Equals(object obj)
        {
            Console.WriteLine("Переопределение метода Equals");
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            Console.WriteLine("Переопределение метода GetHashCode");
            return base.GetHashCode();
        }
    }

}
 
