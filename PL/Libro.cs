using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Libro
    {
        public static void Add()
        {
            ML.Libro libro = new ML.Libro();
            ML.Result result = new ML.Result();
   
            Console.WriteLine("Ingresa el nombre del libro");
            libro.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el numero de paginas");
            libro.NumeroPaginas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la fecha de publicacion");
            libro.FechaPublicacion = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el nombre de la edicion");
            libro.Edicion = Console.ReadLine();

            Console.WriteLine("Ingresa el id del autor");
            libro.Autor.IdAutor = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el id de la editorial");
            libro.Editorial.IdEditorial = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el id del genero");
            libro.Genero.IdGenero = int.Parse(Console.ReadLine());

            result = BL.Libro.Add(libro);

            if(result.Correct == true)
            {
                Console.WriteLine("El libro fue agregado correctamento");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se pudo agregar el libro");
                Console.ReadKey();
            }
        }

        public static void Update()
        {
            ML.Libro libro = new ML.Libro();
            ML.Result result = new ML.Result();

            Console.WriteLine("Ingresa el nombre del libro a actualizar");
            libro.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el nombre del libro");
            libro.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el numero de paginas");
            libro.NumeroPaginas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la fecha de publicacion");
            libro.FechaPublicacion = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el nombre de la edicion");
            libro.Edicion = Console.ReadLine();

            Console.WriteLine("Ingresa el id autor");
            libro.Autor.IdAutor = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el id de la editorial");
            libro.Editorial.IdEditorial = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el id del genero");
            libro.Genero.IdGenero = int.Parse(Console.ReadLine());

            result = BL.Libro.Update(libro);

            if (result.Correct == true)
            {
                Console.WriteLine("El libro fue agregado correctamento");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se pud agregar el libro");
                Console.ReadKey();
            }
        }

        public static void Delete()
        {
            ML.Libro libro = new ML.Libro();
            ML.Result result = new ML.Result();

            Console.WriteLine("Ingresa el id del libro que deseas eliminar");
            libro.Nombre = Console.ReadLine();

            result = BL.Libro.Delete(libro);

            if (result.Correct == true)
            {
                Console.WriteLine("El libro fue agregado correctamento");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se pud agregar el libro");
                Console.ReadKey();
            }
        }
    }
}
