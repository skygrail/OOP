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
        private int[] marks = new int[4];

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

        public int Id
        {
            get
            {
                if (id > 0)
                    return id;
                else return 0;
            }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string Addres
        {
            get { return addres; }
            set { addres = value; }
        }

        public uint TelNumber
        {
            get { return telNumber; }
            set { telNumber = value; }
        }

        public int[] Marks
        {
            get { return marks; }
            set { marks = value; }
        }

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
                    university[i].FirstName = Console.ReadLine();

                    Console.WriteLine("Введите фамилию абитуриента: ");
                    university[i].Surname = Console.ReadLine();

                    Console.WriteLine("Введите отчество абитуриента: ");
                    university[i].MiddleName = Console.ReadLine();

                    Console.WriteLine("Введите адрес абитуриента: ");
                    university[i].Addres = Console.ReadLine();

                    Console.WriteLine("Введите номер абитуриента: ");
                    university[i].TelNumber = uint.Parse(Console.ReadLine());

                    Console.WriteLine("Введите баллы абитуриента: ");
                    for (int k = 0; k < 4; k++)
                    {
                        university[i].Marks[k] = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine(university[0].ToString());

                //Console.WriteLine("Введите значение минимального балла: ");
                //int checkMarks = int.Parse(Console.ReadLine());



            }

        }
        }

      

}
