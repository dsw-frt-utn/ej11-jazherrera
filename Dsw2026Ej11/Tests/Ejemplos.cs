using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
   
    
        public static void EjemploList()
        {
        CasoList caso = new CasoList();

        // Agregar 3 alumnos a la lista
        caso.AgregarAlumno(new Alumno(1, "Juan", 8.5));
        caso.AgregarAlumno(new Alumno(2, "Maria", 9.2));
        caso.AgregarAlumno(new Alumno(3, "Pedro", 7.8));

        // Listar por consola los alumnos
        Console.WriteLine("LISTA DE ALUMNOS:");
        caso.ObtenerAlumnos().ForEach(a => Console.WriteLine(a));

        // Buscar por nombre un alumno que exista
        Console.WriteLine("\nBUSCAR ALUMNO EXISTENTE (Maria):");
        Alumno encontrado = caso.BuscarAlumnoPorNombre("Maria");
        if (encontrado != null)
            Console.WriteLine(encontrado);
        else
            Console.WriteLine("No existe");

        // Buscar por nombre un alumno que no exista
        Console.WriteLine("\nBUSCAR ALUMNO NO EXISTENTE (Lucas):");
        Alumno noExiste = caso.BuscarAlumnoPorNombre("Lucas");
        if (noExiste != null)
            Console.WriteLine(noExiste);
        else
            Console.WriteLine("No existe");

        // Eliminar un alumno y listar
        Console.WriteLine("\nELIMINAR ALUMNO (Pedro):");
        Alumno alumnoEliminar = caso.BuscarAlumnoPorNombre("Pedro");
        if (alumnoEliminar != null)
            caso.EliminarAlumno(alumnoEliminar);

        caso.ObtenerAlumnos().ForEach(a => Console.WriteLine(a));

        // Eliminar el primer elemento de la lista y listar
        Console.WriteLine("\nELIMINAR PRIMER ELEMENTO:");
        caso.EliminarAlumnoEnPosicion(0);

        caso.ObtenerAlumnos().ForEach(a => Console.WriteLine(a));
    }
    
    

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary caso = new CasoDictionary();

        // Agregar 3 alumnos al diccionario
        caso.AgregarAlumno(1, new Alumno(1, "Juan", 8.5));
        caso.AgregarAlumno(2, new Alumno(2, "Maria", 9.2));
        caso.AgregarAlumno(3, new Alumno(3, "Pedro", 7.8));

        // Listar por consola los alumnos
        Console.WriteLine("LISTA DE ALUMNOS:");
        foreach (var alumno in caso.ObtenerDiccionario().Values)
        {
            Console.WriteLine(alumno);
        }

        // Buscar un alumno por clave existente
        Console.WriteLine("\nBUSCAR ALUMNO EXISTENTE (legajo 2):");
        Alumno encontrado = caso.BuscarAlumno(2);
        if (encontrado != null)
            Console.WriteLine(encontrado);
        else
            Console.WriteLine("No existe");

        // Buscar un alumno por clave no existente
        Console.WriteLine("\nBUSCAR ALUMNO NO EXISTENTE (legajo 99):");
        Alumno noExiste = caso.BuscarAlumno(99);
        if (noExiste != null)
            Console.WriteLine(noExiste);
        else
            Console.WriteLine("No existe");

        // Eliminar un alumno por clave y listar
        Console.WriteLine("\nELIMINAR ALUMNO (legajo 1):");
        caso.EliminarAlumno(1);

        foreach (var alumno in caso.ObtenerDiccionario().Values)
        {
            Console.WriteLine(alumno);
        }
    }

    

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        // Datos de ejemplo
        List<Libro> libros = new List<Libro>
    {
        new Libro(1, "Clean Code", 50),
        new Libro(2, "C# in Depth", 80),
        new Libro(16, "The Pragmatic Programmer", 120),
        new Libro(20, "Design Patterns", 150)
    };

        CasoLinq caso = new CasoLinq(libros);

        // 1. Primero
        Console.WriteLine("PRIMERO:");
        Console.WriteLine(caso.GetPrimero());

        // 2. Último
        Console.WriteLine("\nÚLTIMO:");
        Console.WriteLine(caso.GetUltimo());

        // 3. Total precios
        Console.WriteLine("\nTOTAL PRECIOS:");
        Console.WriteLine(caso.GetTotalPrecios());

        // 4. Promedio precios
        Console.WriteLine("\nPROMEDIO PRECIOS:");
        Console.WriteLine(caso.GetPromedioPrecios());

        // 5. Filtrar por ID > 15
        Console.WriteLine("\nLIBROS ID > 15:");
        caso.GetListById().ForEach(Console.WriteLine);

        // 6. Libros formateados
        Console.WriteLine("\nLIBROS FORMATEADOS:");
        caso.GetLibros().ForEach(Console.WriteLine);

        // 7. Mayor precio
        Console.WriteLine("\nMAYOR PRECIO:");
        Console.WriteLine(caso.GetMayorPrecio());

        // 8. Menor precio
        Console.WriteLine("\nMENOR PRECIO:");
        Console.WriteLine(caso.GetMenorPrecio());

        // 9. Mayor al promedio
        Console.WriteLine("\nMAYORES AL PROMEDIO:");
        caso.GetMayorPromedio().ForEach(Console.WriteLine);

        // 10. Ordenados por título DESC
        Console.WriteLine("\nORDENADOS POR TÍTULO DESC:");
        caso.GetOrdenadosPorTituloDesc().ForEach(Console.WriteLine);
    }

}


