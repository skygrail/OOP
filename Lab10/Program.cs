using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace Lab10
{
    class Program
    {
        static void Reaction(object? sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Collection changed: " + e.Action);
        }
        static void Main(string[] args)
        {
            //1.

            Student paidForm, budgetForm;
            Student[] studArr =
                {
                    new Student(18,1,"FIT", "Nastya"),
                    new Student(20,2, "HTIT", "Denis"),
                    paidForm = new Student(22,4, "IEF", "Anya"),
                    budgetForm = new Student(19,2, "FIT", "Kirill")
                };
            var studList = new StudentList(studArr);
            Console.WriteLine(studList);

            studList.Add(new Student());
            studList.Remove(budgetForm);
            Console.WriteLine(studList);
            Console.WriteLine(studList.Find(paidForm));

            //2.

            var listDop = new LinkedList<int>();
            listDop.AddLast(0);
            listDop.AddLast(1);
            listDop.AddLast(2);
            listDop.AddLast(3);
            listDop.AddLast(4);

            int n = 3;

            for (int i = 0; i < n; i++)
                listDop.RemoveLast();

            listDop.AddFirst(-2);
            listDop.AddAfter(listDop.First, -1);
            listDop.AddBefore(listDop.First, -3);


            var list2 = new List<int>(listDop);

            foreach (int item in list2)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Predicate<int> func = delegate (int x)
            {
                return x > 0;
            };
            Console.WriteLine(list2.Find(func));
            Console.WriteLine(list2.FindIndex(0, func));

            //3.

            var observCollect = new ObservableCollection<Student>();

            observCollect.CollectionChanged += Reaction;
            observCollect.Add(paidForm);
            observCollect.Add(budgetForm);
            observCollect.Remove(budgetForm);

        }
    }
}
