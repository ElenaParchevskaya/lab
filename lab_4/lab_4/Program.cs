using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance

// Продукт, вкусняшки, Товар, Цветы, Торт, Часы, Конфеты;
{
    class Program
    {
        static void Main(string[] args)
        {
            Flowers peonies = new Flowers("Пионы", "цветы", 7);
            Flowers roses = new Flowers("Розы", "цветы", 2);
            Clock luch = new Clock("часы", 2);
            Goods goods1 = new Goods("товар1", 1);
            Goods goods2 = new Goods("товар2", 2);
            Product flower1 = peonies;
            peonies.ToPrint();
            goods1.ToPrint();
            goods1 = peonies;
            goods1.ToPrint();
            flower1.ToPrint();
            luch.ToPrint();

            #region same
            Console.WriteLine("\nнаименование");
            IProductSame same1 = new Goods("same", 0);
            IProductSamee same2 = new Goods("same1", 0);
            Pastry pastry1 = new Pastry();
            Cake myTears = new Cake();
            same1.Same();//in
            same2.Same();//in1
            goods1.Same();//ab
            ((IProductSame)goods1).Same();//in
            #endregion

            #region as is
            Console.WriteLine("\nPoint1 AS/IS");
            IProductSame forIsAS = new Goods("is/as", 1);
            Product product1 = goods1;
            Product product2 = goods2 as Product;
            Console.WriteLine(forIsAS is Goods); //true
            Console.WriteLine(product1 is Pastry); //false
            Console.WriteLine("End of Point1\n");
            #endregion
         
            Console.WriteLine("\nArray\n");
       
            Printer printer = new Printer();
            Product[] products = { product1, goods2, pastry1, roses, luch, myTears };

            foreach (var item in products)
            {
                Console.WriteLine('\n');
                printer.IAmPrinting(item);
            }
        }





    }
}