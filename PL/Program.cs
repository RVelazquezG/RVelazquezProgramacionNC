using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Selecciona una opcion");
            Console.WriteLine("1. Agregar libro 2.Actualizar libro 3.Eliminar libro");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {

                case 1:
                    PL.Libro.Add();
                    break;

                case 2:
                    PL.Libro.Update();
                    break;

                case 3:

                    PL.Libro.Delete();
                    break;
            }

        }

    }
}
