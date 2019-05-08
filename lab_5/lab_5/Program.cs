using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    #region old
    interface IPrice
    {
        void Show();
    }

    public class Good : IPrice
    {
        public string name;
        public int price;
        public int weight;
        virtual public void Show()
        {
            Console.WriteLine($"Наименование : {name}    Стоимость: {price}");
        }
    }

    public class Product : Good
    {
        public override void Show()
        {
            Console.WriteLine($"Продукты:  Наименование : {name}    Стоимость : {price}");
        }
        public override string ToString()
        {
            return ($"Type : Продукты, Наименование : {name}, Стоимость : {price}");
        }
    }

    public abstract class Flowers : Good
    {
        public abstract void NameFlowers();
        public override string ToString()
        {
            return ($"Type : Цветы, Наименование : {name}, Стоимость : {price}");
        }

        public override void Show()
        {
            Console.WriteLine($"Цветы: Наименование : {name}    Стоимость : {price}  Вес : {weight}");
        }

        sealed class Rose : Flowers
        {
            new readonly string name = "Розы";
            public override void NameFlowers()
            {
                Console.WriteLine($"Работа с абстрактным классом : Цветы : {name}");
            }
        }
        internal partial class Watch : Good
        {
            public override void Show()
            {
                Console.WriteLine($"Часы:  Наименование : {name}    Стоимость : {price}  Вес : {weight}");
            }
        }
        class Pastry : Good
        { }
        class Cake : Pastry
        {
            public override string ToString()
            {
                return ($"Type : Cake, Наименование : {name}, Стоимость : {price}");
            }
            public override void Show()
            {
                Console.WriteLine($"Cake: Наименование : {name}    Стоимость : {price}  Вес : {weight}");
            }
        }
        class Sweets : Pastry
        {
            public override void Show()
            {
                Console.WriteLine($"Sweets: Наименование : {name}    Стоимость : {price}  Вес : {weight}");
            }
        }
        class Printer
        {
            public virtual void IAmPrinting(IPrice someFlow)
            {
                Console.WriteLine(someFlow.GetType());
                Console.WriteLine(someFlow.ToString());
            }
        }
        #endregion

        struct User
        {
            public string name;
            public int age;

            public User(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Имя : {name}     Возраст : {age}");
            }
            enum Operation
            {
                Add = 1, Substuct, Multiply
            }


            class Program
            {
                static void Main(string[] args)
                {
                    #region old
                    Watch watch1 = new Watch() { name = "Луч", price = 277, weight = 250 };
                    Cake cake1 = new Cake() { name = "Гравские развалины", price = 37, weight = 1770 };
                    cake1.Show();
                    watch1.Show();

                    Console.WriteLine();
                    Product sweets = new Product() { name = "кит кат", price = 2 };
                    sweets.Show();

                    Console.WriteLine();
                    Sweets Sweets1 = new Sweets() { name = "сникерс", price = 3, weight = 100 };
                    Sweets1.Show();
                    IPrice product = new Product() { name = "Печенки", price = 177 };
                    product.Show();
                    ((IPrice)cake1).Show();

                    Console.WriteLine();
                    Product product1 = new Product();
                    Boolean checkPood = product1 is Product;
                    if (checkPood == true)
                    {
                        Console.WriteLine("продукт1 это Продукты");
                    }
                    Console.WriteLine("проукт1 {0} System.ValueType", product is ValueType ? "это" : "это не");
                    Console.WriteLine("проукт1 {0} продукты", product is ValueType ? "это" : "это не");

                    Console.WriteLine();
                    Rose White = new Rose();
                    Flowers WhiteRose = White as Flowers;
                    WhiteRose.NameFlowers();

                    Console.WriteLine();
                    IPrice[] array = new IPrice[4];
                    array[0] = WhiteRose;
                    array[1] = cake1;
                    array[2] = watch1;
                    array[3] = product;
                    Printer printer = new Printer();
                    for (int i = 0; i < 4; i++)
                    {
                        printer.IAmPrinting(array[i]);
                    }

                    #endregion

                    Console.WriteLine("Пользователи");

                    User user1;
                    user1.name = "Пользователь 1";
                    user1.age = 21;
                    user1.DisplayInfo();

                    User user2 = new User("Пользователь 2", 23);
                    user2.DisplayInfo();


                    //Переменные хранят не ссылку на объект, а сам объект. 
                    //(!!!при присваивании одной структуре другую, скопируются все поля)
                    user1 = user2;
                    user1.DisplayInfo();
                    Console.WriteLine();
                    Operation op;
                    op = Operation.Add;
                    Console.WriteLine((int)op);
                    op = Operation.Multiply;
                    Console.WriteLine(op);
                    Console.WriteLine();

                    create_a_present Present = new create_a_present();
                    Present.Push(watch1);
                    Present.Push(WhiteRose);
                    Present.Push(cake1);
                    Present.Push(Sweets1);

                    Present.Show();
                    Console.WriteLine();

                    Present.Delete(watch1);
                    Present.Show();
                    Console.WriteLine();
                    Present.Price();
                    Console.WriteLine();


                    Controller Present1 = new Controller(Present);
                    Present1.MinWeight();
                    Console.WriteLine();
                    Present1.Sort();
                    Console.WriteLine();

                    Console.ReadLine();

                }
            }

        }
    }
}






