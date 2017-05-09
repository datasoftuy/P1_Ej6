using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P1_Ej6
{
    class Program
    {
        static void Main(string[] args)
        {

            float lado1, lado2, lado3;


            Console.WriteLine("Ingrese Lado 1");
            lado1 = Convert.ToInt64(Console.ReadLine());



            Console.WriteLine("Ingrese Lado 2");

            lado2 = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Ingrese Lado 3");

            lado3 = Convert.ToInt64(Console.ReadLine());



            if (lado1 == lado2 && lado3 != lado2)
            {

                Console.WriteLine("El triangulo es isósceles ");
            
            }

            else if (lado1 == lado2 && lado3 == lado1)
            {

                Console.WriteLine("El triangulo es equilatero ");

            }

            else
            {
                Console.WriteLine("El triangulo es escaleno ");
            }

            Console.ReadLine();



        }
    }
}
