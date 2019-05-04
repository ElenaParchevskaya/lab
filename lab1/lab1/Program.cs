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
        }
    }

}
