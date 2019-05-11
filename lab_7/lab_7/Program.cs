using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_7
{
    class A
    {
        interface IMyList<T>
        {
            void Push(T value, MyList<T> list);
            void Dell(T value, MyList<T> list);
            void Show(MyList<T> list);
        }
        class MyList<T> : List<T>, IMyList<T>
        {
            public void Push (T value, MyList<T> list)
            {
                list.Add(value);
            }
            public void Dell(T el, MyList<T> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (el.Equals(list[i]))
                    {
                        list.RemoveAt(i);
                    }
                }
            }
            public void Show(MyList<T> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i].ToString() + " ");
                }
                Console.WriteLine();
            }

            public void Show<U>(MyList<T> list) where U : Watch
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i].ToString() + "\n");
                }
                Console.WriteLine();
            }
        }

        public class Pastry : Watch
        {
            public override string ToString()
            {
                string text = $"Вкусняшки: наименование {name}   стоимость: {price}   вес: {weight}";
                return text;
            }
        }

        public class Good
        {
            public string name;
            public int price;
            public int weight;
            virtual public void Show()
            {
                Console.WriteLine($"Наименование:   {name}   стоимость:   {price}");
            }
        }

        public class Watch : Good
        {
            public override string ToString()
            {
                string text = $"Часы: Наименование : {name}    Стоимость : {price}  Вес : {weight}";
                return text;
            }
        }

        public class Sweets : Good
        {
            public override string ToString()
            {
                string text = $"Сладости: Наименование : {name}    Стоимость : {price}  Вес : {weight}";
                return text;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                MyList<int> List1 = new MyList<int>();
                for (int i = 1; i < 5; i++)
                {
                    List1.Push(i, List1);
                }
                Console.Write("List1:  ");
                List1.Show(List1);
                Console.Write('\n');

                MyList<string> List2 = new MyList<string>();
                string str = "string ";
                for (int i = 1; i < 5; i++)
                {
                    List2.Push((str + i), List2);
                }
                Console.Write("List2: ");
                List2.Show(List2);
                Console.Write('\n');



                try
                {
                    Watch watch1 = new Watch() { name = "Луч", price = 277, weight = 270 };
                    Sweets sweets1 = new Sweets() { name = "печенка", price = 34, weight = 2700 };

                    MyList<Good> List3 = new MyList<Good>();
                    List3.Push(watch1, List3);
                    List3.Push(sweets1, List3);
                    Console.Write("List3: ");
                    //List3.Show<Sweets>(List3); error
                    List3.Show<Watch>(List3);
                    List3.Show<Pastry>(List3);
                    //List3.Show<Good>(List3); error
                    Console.Write('\n');
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Error : " + ex.Message);
                }
                finally
                {
                    Console.Write("Все ладушки \n\n");
                }

                try
                {
                    string path = @"\lab\lab_7\generic.txt";
                    string text = " ";
                    using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("List1 : ");
                        for (int i = 0; i < List1.Count; i++)
                        {
                            sw.Write(List1[i] + " ");
                        }
                        sw.WriteLine();
                    }

                    using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("Дозапись : ");
                        sw.WriteLine("List2 : ");
                        for (int i = 0; i < List2.Count; i++)
                        {
                            sw.Write(List2[i] + " ");
                        }
                    }
                    using (StreamReader sw = new StreamReader(path, System.Text.Encoding.Default))
                    {
                        text = sw.ReadToEnd();
                    }
                    Console.WriteLine("Текст из файла: ");
                    Console.Write(text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error : " + ex.Message);
                }
                finally
                {
                    Console.Write("\nЭто была попытка чтения\n");
                }
            }
        }
    }
}
