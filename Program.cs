using System;
using Escuelita.Entidades;

namespace Escuelita
{
    class Program
    {
        static void Main(string[] args)
        {
            Escuela objEscuela = new Escuela("COBAEP", "México", "Puebla", 1983);
            Console.WriteLine(objEscuela);


            Curso[] arregloCursos = new Curso[3];
            arregloCursos[0] = new Curso() { Nombre = "101" };
            arregloCursos[1] = new Curso() { Nombre = "201", Jornada = TipoJornada.Noche };
            arregloCursos[2] = new Curso() { Nombre = "301" };

            Console.WriteLine($"Curso:{arregloCursos[0].Nombre} ID:{arregloCursos[0].ID} Jornada:{arregloCursos[0].Jornada}");
            Console.WriteLine($"Curso:{arregloCursos[1].Nombre} ID:{arregloCursos[1].ID} Jornada:{arregloCursos[1].Jornada}");
            Console.WriteLine($"Curso:{arregloCursos[2].Nombre} ID:{arregloCursos[2].ID} Jornada:{arregloCursos[2].Jornada}");

        }
    }
}
