using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerGuideReainders
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int a=17, b=4;
            // int quotient = a / b;
            //  int remainder = a % b;
            // Console.WriteLine(a+"/"+b+"is"+quotient +"remainder"+remainder);
            Console.WriteLine("input the height");
            double h;
            string height = Console.ReadLine();
            h = Convert.ToDouble(height);
            Console.WriteLine("input the radius");
            double r;
            string radius = Console.ReadLine();
            r = Convert.ToDouble(radius);

            double pi = 3.1415926;
            double volumn = pi * r * r * h;
            double surfaceArea = 2 * pi * r * (r + h);

            Console.WriteLine("volumn is "+volumn+"cubic units");
            Console.WriteLine("surfaceArea is "+surfaceArea+"square units");
            Console.ReadKey();
            //你是个猪吗?
        }
    }
}
