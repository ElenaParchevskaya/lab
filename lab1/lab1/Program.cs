using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1_a Определить переменные всех примитивных типов + проиницилизировать

            sbyte dSbite = 123;
            short dShot = 12345;
            int i = 2;
            long dLong = 5;             byte dByte = 177;
            ushort dUshort = 77;             uint dUint = 4;             ulong dUlong = 18;             char dChar = 'A';             bool dBoolean = false;             float dFloat = 1.77f;             double dDouble = 17;             decimal dDecimal = 300.5m;             string dString = "hello";             object dObject;             dObject = 1; //an example of boxing
            //1_b явное и неявное приведение

            byte b = 7;             byte c = (byte)(b + 70);             short b1 = b;             int b2 = b1;             long b3 = b2;             decimal b4 = b3;             //             byte b_1 = 7;             int c_1 = b_1 + 70;             decimal a_1 = 77.7m;             long a_2 = (long)a_1;             int a_3 = (int)a_2;             short a_4 = (short)a_3;             byte a_5 = (byte)a_4;

            //1_c упкаковка и распаковка значимых типов             int d = 177;             object o = d;             int f = (int)o;
             //1d Работу с неявно типизированной переменной             var varA = 117;             var varB = "Leka";             Console.WriteLine("Type of var varA = 117; is " + varA.GetType());             Console.WriteLine("Type of var varB = 'Leka'; is " + varB.GetType());            
            //1_e Работы с Nullable переменной             int? i1 = 7;             Nullable<int> i2 = 7;             int? z = null;             if (z.HasValue)                 Console.WriteLine(z.Value);             else                 Console.WriteLine("z is equal to null");

            //2_a Объявить и сравнить строковые литералы
            string s1 = "Vi";
            string s2 = "Bu";
            if (String.Compare(s1,s2) < 0)
            {
                Console.WriteLine("Vi < Bu");
            }
            else if (String.Compare(s1, s2) == 0)
            {
                Console.WriteLine("Vika = Vikaaa");
            }
            else
            {
                Console.WriteLine("Vi > Bu");
            }

            //2_b Создайть три строки на основе String.              string b21 = "Maша Оля ";             string b22 = " Света ";             string b23 = " Вика ";                 //сцепление,              string bPlus = b21 + " " + b22;             string bConcat = String.Concat(bPlus, b23);             Console.WriteLine(bConcat);                 //копирование,              string b24 = string.Copy(b21);             Console.WriteLine("\nКопирование: " + b24);                 //выделение подстроки,              Console.WriteLine("Строка" + b21 + " содержит : " + b21.Contains("работа"));                 //разделение строки на слова,              string[] words = bConcat.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);              foreach (string s in words)             {                 Console.WriteLine(s);             }                 //вставки подстроки в заданную позицию,              Console.WriteLine("\nвставки подстроки в заданную позицию: " + b24.Insert(9, "РАБОТА"));                  //удаление заданной подстроки.             Console.WriteLine("строка  " + b24);             Console.WriteLine("удаление заданной подстроки: " + b24.Replace("Оля", ""));

            //2_с Создайть пустую и null строку. что с ними можно выполнить             string strEmpty = "";             string strNull = null;             Console.WriteLine("Длина '{0}' = {1}.", strEmpty, strEmpty.Length);             strEmpty = String.Copy(b21);             Console.WriteLine("копирование в пустую строку: " + strEmpty);             //2_d Создайть строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в начало и конец строки.             StringBuilder sb = new StringBuilder("String Builder");             Console.WriteLine("\n" + sb);             sb.Remove(3, 3);             Console.WriteLine(sb);             sb.Append(" ! ");             sb.Insert(0, " ! ");             Console.WriteLine(sb);  
        }
    }

}
