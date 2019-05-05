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
            int ii = 2;
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
          //4_a,b Задайть кортеж из 5 элементов с типами int, string, char, string, ulong. + сделать именование элементов             (int first, string second, char third, string fourth, ulong fifth) tuple = (1, "Vika", '&', "Sveta", 1111);             //4c Вывести кортеж на консоль целиком и выборочно (1, 3, 4 элементы)             Console.WriteLine("Tuple: " + tuple);             Console.WriteLine("Tuple 1 3 4: " + tuple.first + " " + tuple.third + ' ' + tuple.fourth);             //4_d Выполнить распаковку кортежа в переменные.             int one1;             string two;             char three;             string four;             ulong fife;             (one1, two, three, four, fife) = tuple;             Console.WriteLine(four + ' ' + two);             //4_e Сравните два кортежа.             var t1 = Tuple.Create(123, "Hello");             var t2 = Tuple.Create(123, "Hello");             Console.WriteLine(t1.Equals(t2)); // True

            //5 Создайть локальную функцию в main и вызовите ее. 
            //Формальные параметры функции – массив целых и строка. 
            //Функция должна вернуть кортеж, содержащий: максимальный и минимальный элементы массива, 
            //сумму элементов массива и первую букву строки .
            (int, int, int, char) FirstF(int[] mass, string str_5)             {                 int min = mass[0];                 int max = mass[0];                 for (int i_5 = 1; i_5 < mass.Length; i_5++)                 {                     if (mass[i_5] > max)                     {                         max = mass[i_5];                     }                 }                 for (int i_5 = 1; i_5 < mass.Length; i_5++)                 {                     if (mass[i_5] < min)                     {                         min = mass[i_5];                     }                 }                 int sum = 0;                 for (int i_5 = 0; i_5 < mass.Length; i_5++)                 {                     sum += mass[i_5];                 }                 return (min, max, sum, str_5[0]);             }             int[] mas_5 = new int[] { 9, 7, 3, 6 };             Console.WriteLine(FirstF(mas_5, "Leka"));             Console.ReadKey(); 
             //3_a Создайть целый двумерный массив и вывести его на консоль в отформатированном виде (матрица)             int[,] myArra = new int[2, 3] {{1,2,3} , {4,5,6}};             for (int i = 0; i < 2; i++)             {                 for (int j = 0; j < 3; j++)                 {                     Console.Write("{0}\t", myArra[i, j]);                 }                 Console.WriteLine();             }             Console.WriteLine();             //3_b Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива.              string[] mySArr = new string[] { "Лека", "Света", "Вика", "Катя", "Лера" };             for (int i=0;i<mySArr.Length; i++)             {                 Console.Write(mySArr[i] + ' ');             }             //Поменяйте произвольный элемент (пользователь определяет позицию и значение).             Console.WriteLine("\nВведите номер позиции, которую хотите изменить: ");             int i_1 = Convert.ToInt32(Console.ReadLine());             Console.WriteLine("Введите значение: ");             mySArr[i_1] = Console.ReadLine();             for (int i = 0; i < mySArr.Length; i++)             {                 Console.Write(mySArr[i] + ' ');             }             Console.WriteLine();             //3_c Создать ступенчатый массив вещественных чисел с 3-мя строками,              //в каждой из которых 2, 3 и 4 столбцов соответственно. Значения массива введите с консоли.             int[][] myArr = new int[3][];             myArr[0] = new int[2];             myArr[1] = new int[3];             myArr[2] = new int[4];             Console.WriteLine("Введите значение: ");             for (int i3 = 0; i3 < 2; i3++)             {                 myArr[0][i3] = int.Parse(Console.ReadLine());             }             Console.WriteLine("Введите значение: ");             for (int i3 = 0; i3 < 3; i3++)             {                 myArr[1][i3] = int.Parse(Console.ReadLine());             }             Console.WriteLine("Введите значение: ");             for (int i3 = 0; i3 < 4; i3++)             {                 myArr[2][i3] = int.Parse(Console.ReadLine()); ;             }              Console.WriteLine("ступенчатый массив: ");             for (int i3 = 0; i3 < 2; i3++)             {                 Console.Write("{0}\t", myArr[0][i3]);             }             Console.WriteLine();             for (int i3 = 0; i3 < 3; i3++)             {                 Console.Write("{0}\t", myArr[1][i3]);             }             Console.WriteLine();             for (int i3 = 0; i3 < 4; i3++)             {                 Console.Write("{0}\t", myArr[2][i3]);             }             Console.WriteLine();             //3_d Создайте неявно типизированные переменные для хранения массива и строки.             var array = new object[3];             var str = "123";
        }
    }

}
