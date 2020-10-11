using System;
using System.Text;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Типы

            bool tbool = true;
            byte tbyte = 255;
            sbyte tsbyte = -128;
            char tchar = 'u';
            decimal tdecimal = 23.12m;
            double tdouble = 23.12;
            float tfloat = 23.12f;
            int tint = 2147483647;
            uint tuint = 4294967295;
            long tlong = 9223372036854775807;
            ulong tulong = 18446744073709551615;
            short tshort = 32767;
            ushort tushort = 65535;

            //Неявное приведение
            double convint = tint;
            short convbyte = tbyte;
            float convuint = tuint;
            int convshort = tshort;
            long convsbyte = tsbyte;

            //Явное приведение
            decimal converShort = (decimal)tshort;
            int converChar = (int)tchar;
            float converUshort = (float)tushort;
            double converUint = (double)tuint;
            long converInt = (long)tint;

            //Класс Convert
            int number = Convert.ToInt32("3");
            int flag = Convert.ToInt32(tbool);

            Console.WriteLine("Класс Conver: number=" + number + " flag=" + flag);

            //Упаковка и распаковка
            int forbox = 18;
            Object intbox = forbox;
            int frombox = (int)intbox;

            //Неявная типизация
            var word = "Hi!";
            var numb = 18;
            Console.WriteLine("Тип переменной word: " + word.GetType());
            Console.WriteLine("Тип переменной numb: " + numb.GetType());

            //Nullable
            Nullable<int> num1 = 15;
            int? num2 = null;
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);

            //var
            var exper = "18";//после определения переменной var её тип
                             //нельзя изменять

            Console.ReadLine();


            //2. Строки

            string Str1 = "Hi", Str2 = "World", Str3 = ", ";

            string copyStr = String.Copy(Str1);
            Console.WriteLine("Скопированная строка: " + copyStr);

            if (string.Compare(Str1, Str2) == 0)
                Console.WriteLine("Строки идентичны");
            else
                Console.WriteLine("Строки не идентичны");

            string Str = Str1 + Str3 + Str2; //склейка строк
            Console.WriteLine("Склеенные строки: " + Str);

            string interStr = $"{Str} new sentence"; //обьединение внутри строки
            Console.WriteLine("Обьединённые внутри строки: " + interStr);

            string subStr = interStr.Substring(2);
            Console.WriteLine("Строка с начальным индексом 2: " + subStr);

            string[] splittStr = interStr.Split(" "); //разбиение строки, вывод слов
            foreach (string v in splittStr)
                Console.WriteLine(v);

            string subStrInsert = subStr.Insert(0, "This is inserted");//Вставка подстроки
            Console.WriteLine("строка со вставкой: " + subStrInsert);

            string subStrDel = subStrInsert.Remove(3, 5);
            Console.WriteLine("Строка с удалённой подстрокой: " + subStrDel);

            string emptStr = String.Empty; //Пустая строка

            string nullStr = null; //null строка

            //проверка на пустую строку
            if (String.IsNullOrEmpty(emptStr))
                Console.WriteLine("Строка \"emptStr\" равна нулю либо null");
            else
                Console.WriteLine("Строка не пуста");

            if (String.IsNullOrEmpty(nullStr))
                Console.WriteLine("Строка \"nullStr\" равна нулю либо пуста");
            else
                Console.WriteLine("строка не пуста");

            //StringBuilder
            StringBuilder builtStr = new StringBuilder("top", 50);

            builtStr.Append(new char[] { 'A', 'B', 'C' });
            builtStr.Insert(0, "Anyyeon");
            builtStr.Remove(5, 2);

            Console.WriteLine("Строка созданная с помощью StringBuilder: " + builtStr);

            Console.ReadLine();

            //3. Массивы

            int[,] Array = { { 7, 7 }, { 3, 4 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write($"{Array[i, j]} \t");

                Console.WriteLine();
            }

            //Массив строк

            string[] ArrayStrings = new string[] { "a", "b", "c", "d", "e" };
            int ArrayStringsLength = ArrayStrings.GetLength(0);

            for (int i = 0; i < ArrayStringsLength; i++)
                Console.Write($"{ArrayStrings[i]} ");

            Console.WriteLine($"\nДлина массива строк: {ArrayStringsLength}");

            Console.WriteLine("Введите номер элемента (от 0 до 5): ");
            int pos = Convert.ToInt32(Console.ReadLine());

            for (; ; )
            {
                if (pos <= 5)
                {
                    Console.WriteLine("Введите текст, которым Вы хотите заменить существующий элемент: ");
                    string newElement = Console.ReadLine();

                    ArrayStrings[pos - 1] = newElement;
                    break;
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите число в промежутке от 0 до 5: ");
                    pos = Convert.ToInt32(Console.ReadLine());
                    continue;
                }
            }

            Console.WriteLine("Новый массив: ");

            for (int i = 0; i < ArrayStringsLength; i++)
                Console.Write($"{ArrayStrings[i]} ");

            Console.WriteLine();
            Console.WriteLine();

            int[][] levelArray = new int[3][];
            levelArray[0] = new int[2];
            levelArray[1] = new int[4];
            levelArray[2] = new int[3];

            for (int i = 0; i < levelArray.Length; i++)
            {
                switch(i)
                {
                    case 0:
                        {
                            for (int k = 0; k < levelArray[i].Length; k++)
                            {
                                Console.WriteLine("Введите "+ levelArray[i].Length + " элемента(-ов) для заполнения первой строки массива");
                                levelArray[i][k] = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 1:
                        {
                            for (int k = 0; k < levelArray[i].Length; k++)
                            {
                                Console.WriteLine("Введите " + levelArray[i].Length + " элемента(-ов) для заполнения второй строки массива");
                                levelArray[i][k] = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        {
                            for (int k = 0; k < levelArray[i].Length; k++)
                            {
                                Console.WriteLine("Введите " + levelArray[i].Length + " элемента(-ов) для заполнения третьей строки массива");
                                levelArray[i][k] = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        Console.WriteLine();
                        break;
                }
            }

            Console.WriteLine("Готовый массив: ");

            for (int i = 0; i < levelArray.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            for (int k = 0; k < levelArray[i].Length; k++)
                            {
                                Console.Write($"{levelArray[i][k]} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 1:
                        {
                            for (int k = 0; k < levelArray[i].Length; k++)
                            {
                                Console.Write($"{levelArray[i][k]} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        {
                            for (int k = 0; k < levelArray[i].Length; k++)
                            {
                                Console.Write($"{levelArray[i][k]} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                }
            }

            Console.WriteLine();
            //Неявно типизированные

            var strArr = "Hello new day";
            var numArr = new[] { 1, 2, 3 };

            Console.WriteLine(strArr);

            foreach (var b in numArr)
                Console.Write($"{b} ");

            Console.WriteLine();
            Console.WriteLine();

            //Кортежи

            (int, string, char, string, ulong) things = (18, "annyeong", 'k', "hi", 1995);

            Console.WriteLine($"{things.Item1},{things.Item2},{things.Item3},{things.Item4},{things.Item5}");
            Console.WriteLine($"{things.Item1},{things.Item2},{things.Item4}");

            //Распаковка
            int thing1 = things.Item1;
            string thing2 = things.Item2;
            char thing3 = things.Item3;
            string thing4 = things.Item4;
            ulong thing5 = things.Item5;

            (int newInt, string newStr, char newCh, string newStr1, ulong newUlong) = things;

            (int, string, char, string, ulong) newThings = (20, "hello", 'c', "goodbye", 2020);

            (newInt, _, _, _, newUlong) = newThings;

            if (things.Equals(newThings))
                Console.WriteLine("Кортежи равны");
            else
                Console.WriteLine("Кортежи не равны");

            Console.WriteLine();

            //Локальная функция

            (int, int, int, char) mixFunc (int[] Arr, string word)
            {
                int max = 0, min = 100, sum = 0;

                for(int i=0;i<Arr.Length;i++)
                {
                    sum += Arr[i];

                    if (Arr[i] <= min)
                        min = Arr[i];

                    if (Arr[i] >= max)
                        max = Arr[i];
                }

                (int, int, int, char) tuple = (max, min, sum, word[0]);
                return tuple;
            }

            int[] fArr = new int[] { 2, 4, 6, 8, 10 };
            string fStr = "bye";
            (int, int, int, char) fTuple = mixFunc(fArr, fStr);

            Console.WriteLine($"MAX: {fTuple.Item1}, MIN: {fTuple.Item2}, SUM: {fTuple.Item3}, LETTER: {fTuple.Item4}");

            Console.WriteLine();

            int checkFunc() //Ошибка  при увеличении заднного значения
            {
                checked
                {
                    int maxLong = 2147483647;
                    return maxLong;
                }
            }

            int uncheckFunc()
            {
                unchecked
                {
                    int maxUnLong = 2147483647;
                    return maxUnLong;
                }
            }

            Console.WriteLine(checkFunc());
            Console.WriteLine(uncheckFunc());

            Console.WriteLine();
        }
    }
}
