using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{

    public abstract class Product
    {
        protected string name;
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return "Type" + base.ToString() + ". Наименование продукта: " + Name;
        }       // переопределение метода (во всех классах)

        virtual public void ToPrint()
        {
            Console.WriteLine(this.ToString());
        }   // виртуальный метод (можно переопределять) - наследование со стороны двух классов

        public abstract void Same();    //метод с интерфейсом (одноименный) int IProduct {get; set;}
    }


    // наследование - механизм получения класса, на основе уже существующего
    class Goods : Product, IProductSame, IProductSamee
    {
        protected int countofProducts;
        public int CountofProducts { get => countofProducts; set => countofProducts = value; }
        public Goods()
        { }

        public Goods(string name, int count)
        {
            this.name = name;
            this.countofProducts = count;
        }

        public override string ToString()
        {
            return " " + base.ToString() + ". Количество продуктов: " + CountofProducts;
        }
        public override void ToPrint()
        {
            Console.WriteLine(this.ToString());
        }

        #region SAME
        public override void Same() //реализация для абстрактного метода
        {
            Console.WriteLine("метод (same) абстрактный");
        }
        void IProductSame.Same()
        {
            Console.WriteLine("метод (same) для интерфейса");
        }
        void IProductSamee.Same()
        {
            Console.WriteLine(" метод (same) для интерфейса1");
        }
        #endregion

        public void Info()
        {
            Console.WriteLine(name + " x" + countofProducts);
        }
    }

    // бесплодный - запечатанный класс - запрещается наследовать
    sealed class Flowers : Goods
    {
        private string nameofFlowers;
        public Flowers(string nameFl, string name, int count) : base(name, count)
        { nameofFlowers = nameFl; }
        public Flowers()
        { }
        public override string ToString()
        {
            return " " + base.ToString() + ". Наименование цветов: " + nameofFlowers;
        }
        public override void ToPrint()
        {
            Console.WriteLine(this.ToString());
        }
    }

    class Clock : Goods
    {
        public Clock(string name, int count) : base(name, count)
        { }
        public override string ToString()
        {
            return " " + base.ToString() + ". Часы ";
        }
        public override void ToPrint()
        {
            Console.WriteLine(this.ToString());
        }
    }

    class Pastry : Product
    {
        public Pastry(string name)
        {
            this.name = name;
        }
        public Pastry() { }
        public override void Same()
        {
            Console.WriteLine(" ");
        }
        public override string ToString()
        {
            return " " + base.ToString();
        }
        public override void ToPrint()
        {
            Console.WriteLine(this.ToString());
        }
    }

    class Cake : Pastry
    {
        public override string ToString()
        {
            return " " + base.ToString() + "Печенка";
        }
        protected string category;
        public string Category { get => category; set => category = value; }
        public Cake(string category, string name) : base(name)
        { this.category = category; }
        public Cake()
        { }

        //переопределение equals
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != this.GetType())
                return false;
            Cake odin = (Cake)obj;
            return (this.category == odin.category);
        }

        //переопределение GetHashCode
        public override int GetHashCode()
        {
            int hash = 17, d = 37;
            string a = Convert.ToString(category);
            hash = string.IsNullOrEmpty(a) ? 0 : category.GetHashCode();
            hash = (hash * 17) + d.GetHashCode();
            return hash;
        }

    }
    class Candy : Pastry
    {

    }


    //доп. класс Printer c полиморфным методом iAmPrinting(SomeAbstractClassorInterface someobj).
    //Формальным параметр метода - ссылка на абстрактный класс или наиболее общий интерфейс
    //В методе iAmPrinting определите тип объекта и вызовите ToString(). 
   
    class Printer
    {
        virtual public void IAmPrinting(Product product)
        {
            Console.WriteLine(product.GetType());
            Console.WriteLine(product.ToString());
        }
    }






}
