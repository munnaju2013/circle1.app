using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle aCircle = new Circle();
            Console.Write("Enter Radious : ");
            aCircle.radious = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Diameter :" + aCircle.GetDiameter() + "\nPerimeter :" + aCircle.GetPerimeter() +
                              "\nArea: " + aCircle.GetArea());
            Console.ReadLine();


        }
    }
}
