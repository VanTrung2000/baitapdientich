
using System;

namespace dientich
{
    class Program
    {
        static void Main(string[] args)
        {
            float width, height;

            Console.Write("width = ");
            width = float.Parse(Console.ReadLine());
            Console.Write("height=");
            height = float.Parse(Console.ReadLine());
            dientich(width, height);

            Console.ReadKey();
        }
        static float dientich(float a,float b){
            float c = a * b;
            Console.WriteLine("dien tich la:" + c);
            return c;

               

}
    }
}

