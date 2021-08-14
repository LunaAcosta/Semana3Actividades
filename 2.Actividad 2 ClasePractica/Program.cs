using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Actividad_2_ClasePractica
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] estudiantes = new string[10];
            
            for (int i = 0; i < estudiantes.Length; i++ )
            {
                Console.Write("ESCRIBA EL NOMBRE DEL ESTUDIANTE  {0}:  ", i);

                estudiantes[i] = Console.ReadLine();

            }
            Console.WriteLine();
            Console.WriteLine("DATOS DE LOS ESTUDIANTES : ");

           // Array.Sort(estudiantes);

            for (int i = 0; i < estudiantes.Length; i++ )
            {
                Console.WriteLine(estudiantes[i]);

            }
            Console.ReadKey();

        }
    }
}
