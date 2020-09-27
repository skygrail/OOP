using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Channels;

namespace Lab_3
{
    partial class Abiturient(out int abiturAge, ref int ref int houseNum)
    {
        Console.WriteLine("Введите возраст клиента");
        abiturAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите номер дома клиента");
        houseNum = int.Parse(Console.ReadLine());
    }
}
