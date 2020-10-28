using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{

    interface Shop
    {
        void Producer();
        void Instruction();
    }

    interface Discounts
    {
        public void InfoAboutDiscounts()
        {
            Console.WriteLine("% Новые скидки!!! %");
        }

        public void GetDiscounts()
        {
            Console.WriteLine("% Получите скидку прямо сейчас!!! %");
        }
    }

    public abstract class Product : Discounts
    {
        protected string name;
        protected int workingLife;
        protected string description;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public int WorkingLife
        {
            get
            {
                return workingLife;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
        }

        public override string ToString()
        {
            return base.ToString()+ " " + name + " " + description + " " + workingLife;
        }

        public virtual void priceIncrease()
        {
            Console.WriteLine("Цена повышена!");
        }

        public virtual void priceReduction()
        {
            Console.WriteLine("Цена понижена!");
        }

        public abstract void Available();
        public abstract void unAvailable();
    }

    public abstract class  Device : Product, Discounts, Shop
    {
        protected int minPrice;
        protected string productModel;
        public void Producer()
        {
            Console.WriteLine("Товар компании Sony");
        }

        void Shop.Instruction()
        {
            Console.WriteLine("Дополнительные инструкции читайте на официальном сайте");
        }

        public override string ToString()
        {
            return base.ToString() + " " + productModel + " " + minPrice;
        }
        public abstract void Instruction();

        public void InfoAboutDiscounts()
        {
            Console.WriteLine("% Новые скидки!!! %");
        }
        public void GetDiscounts()
        {
            Console.WriteLine("% Получите скидку прямо сейчас!!! %");
        }
    }



}

