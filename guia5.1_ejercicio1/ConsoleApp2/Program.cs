using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad1, edad2, edad3, edad4, sumaE;
            double m1, m2, m3, m4, monto;
            Console.WriteLine("Ingrese el monto a repartir");
            monto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese las 4 edades de las niñas");
            edad1 = Convert.ToInt32(Console.ReadLine());
            edad2 = Convert.ToInt32(Console.ReadLine());
            edad3 = Convert.ToInt32(Console.ReadLine());
            edad4 = Convert.ToInt32(Console.ReadLine());
            sumaE = edad1 + edad2 + edad3 + edad4;

            m1 = (monto * edad1)/sumaE;
            m2 = (monto * edad2)/sumaE;
            m3 = (monto * edad3)/sumaE;
            m4 = (monto * edad4)/sumaE;

            Console.WriteLine("La niña 1 tiene " + edad1 + " años y recibira $: " + m1);
            Console.WriteLine("La niña 2 tiene " + edad2 + " años y recibira $: " + m2);
            Console.WriteLine("La niña 2 tiene " + edad3 + " años y recibira $: " + m3);
            Console.WriteLine("La niña 2 tiene " + edad4 + " años y recibira $: " + m4);

        }
    }
}
