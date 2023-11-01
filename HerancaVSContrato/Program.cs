using HerancaVSContrato.Model.Entities;
using HerancaVSContrato.Model.Enums;

namespace HerancaVSContrato
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            IShape s1 = new Circle() {Radius = 2.00, Color = Color.White};
            IShape s2 = new Rectangle() {Width = 3.5, Height = 4.2, Color = Color.Black};
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}

