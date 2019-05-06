using System;
using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;

namespace lab_2 {
    //класс Вектор. 
    partial class Vector     {
        //файлы
        private int ax;         private int ay;         private static int numberofVectors = 0;         public readonly int ID;         private const string information = "I am happy!!!";         private double moduleZ = 0;          private int sum;     }     partial class Vector     {
        //конструкции
        public Vector() //
        {             ax = -1;             ay = 1;             ID = GetHashCode();             numberofVectors++;         }         public Vector(int _ax, int _ay)         {             ax = _ax;             ay = _ay;             ID = GetHashCode();             numberofVectors++;         }         static Vector() //статический конструктор (конструктор типа);
        {             numberofVectors = 7;             Console.WriteLine($"Первый вектор. { numberofVectors}");          }

        //свойста
        public int Ax         {             get { return ax; }             set { ax = value; }         }         public int Ay         {             get { return ay; }             set { ay = value; }         }         public int Sum         {             get { return sum; }             set { sum = value; }         }         public double ModuleZ         {             get { return moduleZ; }             set { moduleZ = value; }         }
        public static int NumberofVectors         {             get { return numberofVectors; }             private set { numberofVectors = value; }         }     }     partial class Vector     {
        //методы
        public void Info()         {             Console.WriteLine($"ax = { ax}, ay = { ay}");         }         static void StaticInfo()         {             Console.WriteLine($"Всего создано векторов: { numberofVectors}");         }
        //реализовать метод - модуль вектора, 
        public double CalculateModule(int x, int y, double module)         {             module = Math.Sqrt(x * x + y * y);             return module;         }         public void CalculateModule1(ref int x, ref int y, out double module)         {             module = Math.Sqrt(x * x + y * y);         }         public void CalculateModule(int x, int y, ref double module)         {             module = Math.Sqrt(x * x + y * y);         }
        //метод - скалярного произведения, 
        public void CalculateSc(int ax, int ay, int bx, int by, out int sc)         {             sc = ax * bx + ay * by;         }
        //метод - сложения, 
        public void CalculateSum(int ax, int ay, int bx, int by, out int sumx, out int sumy)         {             sumx = ax + bx;             sumy = ay + by;         }
        //метод - умножения на константу. 
        public void MultiplicationConst(int x, int y, out int sumx, out int sumy, int cnst)         {             sumx = x * cnst;             sumy = y * cnst;         }
        //сумма всех эелемнтво
        public void SumElement(int x, int y, ref int sum)         {             sum = x + y;         }     }     class privateVector     {         public static int ax;         private privateVector() { }// закрытый конструктор; 
    }     partial class Vector     {         public override string ToString()         {             return numberofVectors + ": ax = " + ax + ", ay = " + ay;         }         public override bool Equals(object obj)         {             if (obj == null || this.GetType() != obj.GetType())             {                 return false;             }             return this == obj;         }         public override int GetHashCode()         {             return Convert.ToInt32(Math.Exp(ax) + ay);         }     }

    class Program
    {
        static void Main(string[] args)
        {
            privateVector.ax = 100;     //вызов закрытого конструктора
            Console.WriteLine($"Вектор через приватный конструктор: {privateVector.ax}");
            Vector VectorA = new Vector();
            VectorA.Info();
            Vector VectorB = new Vector(2, 2);
            VectorB.Info();
            Console.WriteLine($"Переопределение ToString: {VectorB.ToString()}");
            double modul = 100;
            modul = VectorB.CalculateModule(VectorB.Ax, VectorB.Ay, modul);
            Console.WriteLine(modul);

            //ref out

            int x = VectorB.Ax;             int y = VectorB.Ay;
             double modul1;             VectorB.CalculateModule1(ref x, ref y, out modul1);             Console.WriteLine(modul1);
             int scp;             VectorA.CalculateSc(VectorA.Ax, VectorA.Ay, VectorB.Ax, VectorB.Ay, out scp);             Console.WriteLine(scp);
             int sumX, sumY;             VectorA.CalculateSum(VectorA.Ax, VectorA.Ay, VectorB.Ax, VectorB.Ay, out sumX, out sumY);             Console.WriteLine($"Сумма векторов = ({ sumX},{ sumY})");
             int cnsT = Convert.ToInt32(Console.ReadLine());             VectorA.MultiplicationConst(VectorA.Ax, VectorA.Ay, out sumX, out sumY, cnsT);             Console.WriteLine($"Произведение векторов = ({ sumX},{ sumY})");



            //Массив объектов

            int size = 5;             Vector[] vectors = new Vector[size];             Random rand = new Random();             int sum = 0;             for (int i = 0; i < size; i++)             {                 vectors[i] = new Vector(rand.Next(minValue: -7, maxValue: 7), rand.Next(minValue: -7, maxValue: 7));                 vectors[i].SumElement(vectors[i].Ax, vectors[i].Ay, ref sum);                 vectors[i].Sum = sum;             }             double md = 0;             vectors[2].CalculateModule(vectors[2].Ax, vectors[2].Ay, ref md);             vectors[2].ModuleZ = md;             vectors[4].CalculateModule(vectors[4].Ax, vectors[4].Ay, ref md);             vectors[4].ModuleZ = md;              Console.WriteLine("Создан массив объектов:");             for (int i = 0; i < size; i++)             {                 Console.WriteLine($"Вектор #{ i} x =  { vectors[i].Ax}, y = { vectors[i].Ay}. Hash: { vectors[i].GetHashCode()}. Module = { vectors[i].ModuleZ}. Sum = { vectors[i].Sum}");             }             Console.WriteLine(" Сравнение первого и второго объекта: " + Equals(vectors[0], vectors[1]));             Console.WriteLine(" Тип объекта: " + vectors[1].Ax.GetType());             Console.WriteLine("вектора с заданным модулем:");             double max, min = max = vectors[0].Sum;             int placeMin, placeMax = placeMin = 0;             for (int i = 0; i < size; i++)             {                 if (vectors[i].ModuleZ != 0)                 {                     Console.WriteLine($"Vector #{ i} x =  { vectors[i].Ax}, y = { vectors[i].Ay}. Hash: { vectors[i].GetHashCode()}. Module = { vectors[i].ModuleZ}. Sum = { vectors[i].Sum}");                 }                 if (min > vectors[i].Sum) { min = vectors[i].Sum; placeMin = i; }                 if (max < vectors[i].Sum) { max = vectors[i].Sum; placeMax = i; }             }             Console.WriteLine($"MinSum:Vector #{ placeMin} x =  { vectors[placeMin].Ax}, y = { vectors[placeMin].Ay}. Hash: { vectors[placeMin].GetHashCode()}. Module = { vectors[placeMin].ModuleZ}. Sum = { vectors[placeMin].Sum}");             Console.WriteLine($"MaxSum:Vector #{ placeMax} x =  { vectors[placeMax].Ax}, y = { vectors[placeMax].Ay}. Hash: { vectors[placeMax].GetHashCode()}. Module = { vectors[placeMax].ModuleZ}. Sum = { vectors[placeMax].Sum}");              var someType = new { AXst = -3 };             Console.WriteLine($"Анонимный тип, определяющий вектор с элементом AXst = { someType.AXst}");         }      } } 
