using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Actividad3ClasePractica
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] genero = new string[10];
            string[] estudiantes = new string[10];

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.Write("INGRESE EL NOMBRE DEL ALUMNO {0}:  ", i);
                estudiantes[i] = Console.ReadLine();

                Console.Write("SELECCIONE SU GENERO F / M {0} :  ", i);
                genero[i] = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("DATOS DE LOS ESTUDIANTES: ");
            Console.WriteLine();
            // Array.Sort(estudiantes);


            for (int i = 0; i < estudiantes.Length; i++)


            {
            
                Console.WriteLine("SU NOMBRE ES : {0} | DEL GENERO : {1}",estudiantes[i], genero[i]);
               
                //if (genero[i] == "F")
                
                    
                

               // Console.WriteLine(genero[i]);
            }
            Console.ReadKey();

        }

    }
}
