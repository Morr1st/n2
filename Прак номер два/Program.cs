using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class program
{
    static void Main(string[] args)
    {
       
      Console.WriteLine("Какое задание Вы хотите просмотреть? 1,2,3:");
      int choose = Convert.ToInt32(Console.ReadLine());
      switch (choose)
        {
            case 1:
                Console.WriteLine("Введите a,b,c");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                ReshitOnline gdz = new ReshitOnline();
                ReshitOnline.Znaki(a, b, c, 0);
            break;
            case 2:
                while (true)
                {
                    Plusik pls = new Plusik();
                    int n = Convert.ToInt32(Console.ReadLine());
                    pls.SetNumber(n);
                }
            break;
        }
    }
    class ReshitOnline // Задание 1
    {
        private int a;
        private int b;
        private int c;
        private float d;
        public static void Znaki(int a, int b, int c, float d)
        {
            Discrim(a, b, c, d);
        }
        private static void Discrim(int a, int b, int c, float d) {
            d = (b * b) - (4 * a * c);
            Proverka(a,b,c,d);
        }
        private static void Proverka(int a, int b, int c,float d)
        {
            if (d > 0)
            {
                CalculateRoots(a,b,c,d);
            }
            if ( d <= 0)
            {
                Console.WriteLine("Корней нет");
            }
        }
        static void CalculateRoots(int a, int b, int c, float d) {
            float x = (-b + (d / d)) / 2 * a;
            Console.WriteLine(x);
        }
    }
    class Plusik //Задание 2
    {
        private int n;
        public bool SetNumber(int number)
        {
            n = 0;
            if (number == n+1)
            {
                n++;
                Console.WriteLine("Правильно!");
                return true;     
            }
            else
            {
                n = 0;
                Console.WriteLine("Неправильно, начинаем сначала!");
                return false;
            }
        }
    }
}