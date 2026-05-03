using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia5._1_ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            double masa;
            int budines, paquetes, cajas, budines_sobrantes;
            Console.WriteLine("Ingrese la cantidad de masa a producir en kg:");
            masa = (Convert.ToDouble(Console.ReadLine()))*1000;
            budines = (int)(masa / 55);
            paquetes = (int)(budines / 12);
            cajas = (int)(paquetes / 20);
            budines_sobrantes = budines % 12;
            Console.WriteLine("Con la cantidad de masa ingresada se pueden producir " + budines + " budines, que se pueden empaquetar en " + paquetes + " paquetes, que a su vez se pueden colocar en " + cajas + " cajas. Quedarán " + budines_sobrantes + " budines sobrantes.");


        }
    }
}
