using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{

        private Dictionary<int, Alumno> alumnos;

        public CasoDictionary()
        {
            alumnos = new Dictionary<int, Alumno>();
        }

        // Agregar un alumno al diccionario
        public void AgregarAlumno(int legajo, Alumno alumno)
        {
            alumnos[legajo] = alumno;
        }

        // Buscar un alumno utilizando la clave (legajo)
        public Alumno BuscarAlumno(int legajo)
        {
            if (alumnos.ContainsKey(legajo))
            {
                return alumnos[legajo];
            }

            return null;
        }

        // Retornar el diccionario completo
        public Dictionary<int, Alumno> ObtenerDiccionario()
        {
            return alumnos;
        }

        // Eliminar un alumno utilizando la clave (legajo)
        public bool EliminarAlumno(int legajo)
        {
            return alumnos.Remove(legajo);
        }
    }

