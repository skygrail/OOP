using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    partial class Abiturient
    {
        private readonly int id;
        private string surname;
        private string firstName;
        private string middleName;
        private string addres;
        private uint telNumber;
        private int[] marks = new int [4];

        static int counterAbi = 0;

        static void classInfo()
        {
            Console.WriteLine(counterAbi);
        }

        public Abiturient(string surname, string firstName, string middleName, string addres, uint telNumber, int[] marks)
        {
            this.surname = surname;
            this.firstName = firstName;
            this.middleName = middleName;
            this.addres = addres;
            this.telNumber = telNumber;
            this.marks = marks;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Сколько абитуриентов будет в списке?");
                sbyte counter = sbyte.Parse(Console.ReadLine());

                Abiturient[] university = new Abiturient[counter];

                for (int i = 0; i < counter; i++) 
                {
                    Console.WriteLine($"Добавляем {i + 1} абитуриента:");
                    university[i] = new Abiturient();

                    Console.WriteLine("Введите имя абитуриента: ");
                    university[i].firstName = Console.ReadLine();

                    Console.WriteLine("Введите фамилию абитуриента: ");
                    university[i].surname = Console.ReadLine();

                    Console.WriteLine("Введите отчество абитуриента: ");
                    university[i].middleName = Console.ReadLine();

                    Console.WriteLine("Введите адрес абитуриента: ");
                    university[i].addres = Console.ReadLine();

                    Console.WriteLine("Введите номер абитуриента: ");
                    university[i].telNumber = uint.Parse(Console.ReadLine());

                    Console.WriteLine("Введите оценки абитуриента: ");
                    for (int k = 0; k < 4; k++)
                    {
                        university[i].marks[k] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine(university[0].ToString());
                }
            }
        }
    }
}
