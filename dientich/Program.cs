
using System;

namespace dientich
{
    class Program
    {
        static void Main(string[] args)
        {
            float width,height;

            Console.Write("width = ");
            width = float.Parse(Console.ReadLine());
            Console.Write("height=");
            height = float.Parse(Console.ReadLine());
            float dientich = width * height;
            Console.WriteLine("Dien tich HCN la: " + dientich);

            Console.ReadKey();
        }
    }
}

