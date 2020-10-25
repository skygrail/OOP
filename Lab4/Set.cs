﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Set
    {
        internal int[] items;
        public Owner SetOwner;
        public Date SetDate;
        public Set()
        {
            items = new int[] { 19, 28, 37, 46, 5 };
            SetOwner = new Owner();
            SetDate = new Date();
        }

        public Set(int[] array)
        {
            items = new int[array.Length];
            array.CopyTo(items, 0);
            SetOwner = new Owner();
            SetDate = new Date();
        }

        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < items.Length) return items[i];
                else return 0;
            }
        }

        public void SelfCheck()
        {
            bool isChenged = false;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[i] == items[j])
                    {
                        int addvar = items[^1];
                        items[^1] = items[j];
                        items[j] = addvar;
                        Array.Resize<int>(ref items, items.Length - 1);

                        isChenged = true;
                    }
                }
            }
            Array.Sort(items);
            if (isChenged)
            {
                Console.WriteLine("Во множестве были повторяющиеся элементы \n Множество изменино!");
                ShowSet();
            }
        }

        public void ShowSet()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(this.items[i] + " ");
            }
            Console.WriteLine();
        }
        public static bool operator >(int[] numbers, Set obj)
        {
            int amountIsInSet = 0;
            foreach (int number in numbers)
            {
                bool isInSet = false;
                foreach (int it in obj.items)
                {
                    if (number == it)
                    {
                        Console.WriteLine($"Элемент {number} принадлежит данному множеству");
                        isInSet = true;
                        amountIsInSet++;
                        break;
                    }
                }
                if (!isInSet) Console.WriteLine($"Элемент {number} не принадлежит данному множеству");
            }
            if (amountIsInSet == numbers.Length) return true;
            else return false;
        }

        public static bool operator <(int[] subset, Set obj)
        {
            int matches = 0;
            foreach (int itInSubset in subset)
            {
                foreach (int itInObj in obj.items)
                {
                    if (itInSubset == itInObj)
                    {
                        matches++;
                        break;
                    }
                }
            }
            if (matches == subset.Length) return true;
            else return false;
        }

        public static Set operator %(Set obj1, Set obj2)
        {
            int crossedlenght;
            int crossPos = 0;
            if (obj1.items.Length >= obj2.items.Length)
                crossedlenght = obj1.items.Length;
            else
                crossedlenght = obj2.items.Length;
            int[] crossedItems = new int[crossedlenght];

            foreach (int obj1it in obj1.items)
            {
                foreach (int obj2it in obj2.items)
                {
                    if (obj1it == obj2it)
                    {
                        crossedItems[crossPos++] = obj1it;
                        break;
                    }
                }
            }

            Array.Resize<int>(ref crossedItems, crossPos);
            Set crossedSet = new Set(crossedItems);
            return crossedSet;
        }

        //public static bool operator !=(Set obj1, Set obj2)
        //{
        //    int counter = 0;
        //    if (obj1.items.Length != obj2.items.Length)
        //        return false;
        //    else
        //    {
        //        foreach (int obj1it in obj1.items)
        //        {
        //            foreach (int obj2it in obj2.items)
        //            {
        //                if (obj1it == obj2it)
        //                {
        //                    counter++;
        //                }
        //            }
        //        }
        //    }

        //    if (obj1.items.Length == counter)
        //    {
        //        return true;
        //    }
        //}

        //public static bool operator ==(Set obj1, Set obj2)
        //{
        //    int counter = 0;
        //    if (obj1.items.Length != obj2.items.Length)
        //        return false;
        //    else
        //    {
        //        foreach (int obj1it in obj1.items)
        //        {
        //            foreach (int obj2it in obj2.items)
        //            {
        //                if (obj1it == obj2it)
        //                {
        //                    counter++;
        //                }
        //            }
        //        }
        //    }

        //    if (obj1.items.Length == counter)
        //    {
        //        return true;
        //    }
        //}

        public static bool operator >>(Set set, int position)
        {
            int addVar;
            bool deletedOnce = false;
            for (int i = 0; i < set.items.Length; i++)
            {
                if (position == i + 1)
                {
                    deletedOnce = true;
                    addVar = set.items[i];
                    set.items[i] = set.items[set.items.Length - 1];
                    set.items[set.items.Length - 1] = addVar;
                    Array.Resize<int>(ref set.items, set.items.Length - 1);
                }
            }
            return deletedOnce;
        }

        public static bool operator <<(Set set, int newItem)
        {
            bool addedOnce = false;
            for (int i = 0; i < set.items.Length; i++)
            {
                Array.Resize<int>(ref set.items, set.items.Length + 1);
                if (i + 1 == set.items.Length)
                {
                    Array.Resize<int>(ref set.items, set.items.Length + 1);
                    addedOnce = true;
                    set.items[set.items.Length + 1] = newItem;
                }
            }
            return addedOnce;
        }

    }

    internal class Owner
    {
        private string Id { get; }
        private string Name { get; }
        private string Organisation { get; }
    }

    public class Date
    {
        private int Day { get; }
        private int Month { get; }
        private int Year { get; }

    }

    static class StaticOperation
    {
        public static string FindMin(this String str)
        {
            return " ";
        }

        public static void sortSet(this Set set)
        {
            int temp;
            for (int i = 0; i < set.items.Length - 1; i++)
            {
                for (int j = 1; j < set.items.Length - i - 1; j++)
                {
                    if (set.items[j] > set.items[j + 1])
                    {
                        temp = set.items[j];
                        set.items[j] = set.items[j + 1];
                        set.items[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < set.items.Length; i++)
            {
                Console.Write(set.items[i] + " ");
            }
            Console.WriteLine();
        }

    }
}


