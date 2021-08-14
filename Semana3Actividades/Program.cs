using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3Actividades
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombers;

            ushort num = 1;



            do

            {

                try

                {
                    Console.WriteLine("LUNA ACOSTA; KEVIN ALEXANDER");
                    Console.WriteLine();
                    Console.Write("INGRESE LA CATIDAD DE VALORES A CAPTURAR:  ");
                    num = UInt16.Parse(Console.ReadLine());
                }
                catch
                {
                    continue;
                }
            } while (num == 0);
            nombers = new string[num];

            for (int i = 0; i < num; i++)

            {
                Console.Write("Ingrese El Valor {0}: ", i);

                nombers[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("INTRODUCIDO LOS {0} VALORES ", num);

            Console.WriteLine("Presione INTRO para Pintarlos");
            Console.WriteLine();
            string a = Console.ReadLine();

            for (int i = 0; i < num; i++)

            {

                Console.WriteLine("VALOR {0}: {1}", i, nombers[i]);

            }



            a = Console.ReadLine();

        }
    }
}
