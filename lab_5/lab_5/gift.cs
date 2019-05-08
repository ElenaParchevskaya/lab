using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    class create_a_present
    {
        public List<Good> Present;
        public create_a_present()
        {
            Present = new List<Good>();
        }

        public void Push(Good El)
        {
            Present.Add(El);
        }

        public void Delete(Good El)
        {
            for (int i = 0; i < Present.Count; i++)
            {
                if (El.Equals(Present[i]))
                {
                    Present.RemoveAt(i);
                }
            }
        }

        public void Show()
        {
            Console.WriteLine("Ваш подарок : ");
            for (int i = 0; i < Present.Count; i++)
            {
                Present[i].Show();
            }
            Console.WriteLine();
        }

        public void Price()
        {
            int Price = 0;
            for (int i = 0; i < Present.Count; i++)
            {
                Price = Price + Present[i].price;
            }
            Console.WriteLine($"Стоимость подарка : {Price}");
        }

    }

}