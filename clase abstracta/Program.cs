using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_abstracta
{
    public abstract class TrianguloB
    {
        public abstract void Perimetro();

        public abstract void Area();

    }
    public class Escaleno : TrianguloB
    {
        private double num1 = 9;
        private double num2 = 4;
        public override void Area()
        {
            Console.WriteLine("ESCALENO");
            Console.WriteLine();
            Console.WriteLine("El area es: " + (num1*num2)/2);
        }

        public override void Perimetro()
        {
            Console.WriteLine("El perimetro es: " + (num1 + num2));
        }
    }
    public class Acutangulo : TrianguloB
    {
        private double num1= 5;
        private double num2= 10;
        public override void Area()
        {
            Console.WriteLine("TRIÀNGULO");
            Console.WriteLine();
            Console.WriteLine("El area es: "+ (num1*num2/2));
        }

        public override void Perimetro()
        {
            Console.WriteLine("El perimetro es: " + (num1+num2));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Acutangulo acutangulo= new Acutangulo();
            Escaleno escaleno= new Escaleno(); 
            
            acutangulo.Area();
            acutangulo.Perimetro();
            Console.WriteLine();
            escaleno.Area();
            escaleno.Perimetro();
            Console.WriteLine();
        }
    }
}
