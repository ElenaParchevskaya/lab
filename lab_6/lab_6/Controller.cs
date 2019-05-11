using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    class Controller : create_a_present
    {
        public create_a_present Present1 = new create_a_present();

        public Controller(create_a_present Present1)
        {
            this.Present1 = Present1;
        }

        public void MinWeight()
        {
            int weight = Present1.Present[0].weight;
            int el = 0;
            for (int i = 0; i < Present1.Present.Count; i++)
            {
                if (weight > Present1.Present[i].weight)
                {
                    weight = Present1.Present[i].weight;
                    el = i;
                }
            }
            Console.WriteLine($"Вариант с минимальным весом : {Present1.Present[el].weight}  ");
            Present1.Present[el].Show();
        }

        public void Sort()
        {
            Good temp;
            for (int i = 0; i < Present1.Present.Count; i++)
            {
                for (int j = i + 1; j < Present1.Present.Count; j++)
                {
                    if (Present1.Present[i].weight > Present1.Present[j].weight)
                    {
                        temp = Present1.Present[i];
                        Present1.Present[i] = Present1.Present[j];
                        Present1.Present[j] = temp;
                    }
                }
            }
            Console.WriteLine("Сортировка подарка : ");
            for (int f = 0; f < Present1.Present.Count; f++)
            {
                Present1.Present[f].Show();
            }



        }


    }
}