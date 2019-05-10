using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
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
            Console.WriteLine($"Наименование : {name}  Стоимость : {price}");
        }
    }
    public class Product : Good
    {
        public override void Show()
        {
            Console.WriteLine($"Продукты: Наименование : {name}   Стоимость: {price}");
        }
        public override string ToString()
        {
            return ($"Тип: Продукты, наименование: {name}, Стоимость : {price}");
        }
    }

    public abstract class Flowers : Good
    {
        public abstract void NameFlowers();
        public override string ToString()
        {
            return ($"Тип : Продукты, наименование : {name},  Стоимость : {price} ");
        }

        public override void Show()
        {
            Console.WriteLine($"Цвветы: Наименование : {name}    Стоимость : {price}  Вес : {weight}");
        }
    }

    sealed class Rose : Flowers
    {
        new readonly string name = "Розы";
        public override void NameFlowers()
        {
            Console.WriteLine($"Работа с абстрактным классом : Тип цветы : {name}");
        }
    }
    internal partial class Watch : Good
    {
        public override void Show()
        {
            Console.WriteLine($"Часы: Наименование : {name}    Стоимость : {price}  Вес : {weight}");
        }
        public override string ToString()
        {
            return ($"Тип : Часы, Наименование : {name}, Стоимость: {price}");
        }
    }

    class Pastry : Good
    { }

    class Cake : Pastry
    {
        public override string ToString()
        {
            return ($"Тип : Cake, Наименование : {name}, стоимость : {price}");
        }
        public override void Show()
        {
            Console.WriteLine($"Cake: Наименование : {name}  Стоимость : {price}  Вес : {weight}");
        }
    }

    class Sweets : Pastry
    {
        public override void Show()
        {
            Console.WriteLine($"Вкусняшки: Наименование : {name}    Стоимость : {price}  Вес : {weight}");
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
            Console.WriteLine($"Имя : {name}   Возраст : {age}");
        }
    }

    enum Operation
    {
        add = 1, Substruct, Multiply
    }
    #endregion


    // ИСКЛЮЧЕНИЯ - EXCEPTIONS

    class Division : Exception
    {
        public Division()
        {
            Console.WriteLine($"Попытка делить на ноль. " + base.Message);
        }
    }

    class InputError : Exception
    {
        public InputError()
        {
            Console.WriteLine($"Неправильная цена :  " + base.Message);
        }
    }

    class WrongIndex : Exception
    {
        public WrongIndex(string massage) : base(massage)
        { }
    }

    class Program
    {
        static void Main(string[] srgs)
        {
            // деление на 0
            try
            {
                Console.WriteLine("\n Деление на ноль: ");
                Console.WriteLine("Ввод x : ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ввод y : ");
                int y = Convert.ToInt32(Console.ReadLine());

                if (y != 0)
                {
                    float result = x / y;
                    Console.WriteLine("{0} деленное на {1} = {2}", x, y, result);
                }
                else
                {
                    throw new Division();
                }
            }
            catch (Division z)
            { }

            catch
            {
                Console.WriteLine("Ошибка");
            }

            //Ввод неверных данных
            Console.WriteLine("/nНеверные данные: ");
            try
            {
                Watch Luch = new Watch() { name = "Luch", weight = 250 };
                Console.WriteLine("Введите цену : ");
                int pri = Convert.ToInt32(Console.ReadLine());

                string stu = "Ошибка";

                if (pri > 0)
                {
                    Console.WriteLine($"Price : {pri}");
                }
                else
                {
                    throw new InputError();
                }
            }

            catch (InputError ex)
            { }

            //неправильный формат данных

            Console.WriteLine("\nНеправильный формат данный : ");
            try
            {
                Watch ziko = new Watch() { name = "Зико", price = 277 };
                Console.WriteLine("Введите вес : ");
                string weghtWatch = Console.ReadLine();
                Console.WriteLine(" Вес  : {0}", weghtWatch);

                int num;
                bool isNum = int.TryParse(weghtWatch, out num);
                if (isNum)
                {
                    Console.WriteLine($"Вес : {weghtWatch}");
                }
                else
                {
                    SystemException exception = new SystemException();
                    throw exception;
                }
            }
            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
                Console.WriteLine(f.TargetSite + "\n\n" + f.StackTrace);
            }
            catch (SystemException el)
            {
                Console.WriteLine($"Неправильно введ вес :  " + el.Message);
                Console.WriteLine(el.TargetSite + "\n\n" + el.StackTrace);
            }

            Console.WriteLine();


            Console.WriteLine("\nПример: ");
            object obj = null; //null
            char ch = 'v';

            try
            {
                bool i = (bool)obj;
                // int i2 = ch;
            }
            catch (NullReferenceException n)
            {
                Console.WriteLine("\nnull ссылка\n");
                Console.WriteLine(n.Message);
                Console.WriteLine(n.TargetSite + "1\n\n" + n.StackTrace);

            }
            catch (InvalidCastException a)
            {
                Console.WriteLine("\n In Vaid\n");
                Console.WriteLine(a.Message);
                Console.WriteLine(a.TargetSite + "2\n\n" + a.StackTrace);
            }

            catch (Exception ex) when ((ex.GetType() != typeof(System.InvalidCastException)))
            {
                Console.WriteLine("\nисключение:\n");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite + "3\n\n" + ex.StackTrace);
                throw;
            }

            catch { Console.WriteLine("\nempty catch\n"); }

            finally
            {
                Console.WriteLine("Все =Р ");
            }


        }
    }
}
