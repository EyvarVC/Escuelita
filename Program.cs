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


            objEscuela.Cursos = new Curso[3]
            {
                 new Curso() { Nombre = "101" },
                 new Curso() { Nombre = "201", Jornada = TipoJornada.Noche },
                 new Curso() { Nombre = "301" }
            };

            /* Console.WriteLine($"Curso:{objEscuela.Cursos[0].Nombre} ID:{objEscuela.Cursos[0].ID} Jornada:{objEscuela.Cursos[0].Jornada}");
            Console.WriteLine($"Curso:{objEscuela.Cursos[1].Nombre} ID:{objEscuela.Cursos[1].ID} Jornada:{objEscuela.Cursos[1].Jornada}");
            Console.WriteLine($"Curso:{objEscuela.Cursos[2].Nombre} ID:{objEscuela.Cursos[2].ID} Jornada:{objEscuela.Cursos[2].Jornada}"); */

            ImprimeCursosForEach(objEscuela);


        }


        private static void ImprimeCursosWhile(Escuela escuela)
        {
            int contador = 0;
            while (contador < escuela.Cursos.Length)
            {
                Console.WriteLine($"Curso:{escuela.Cursos[contador].Nombre} ID:{escuela.Cursos[contador].ID} Jornada:{escuela.Cursos[contador].Jornada}");
                contador++;
            }

        }

        private static void ImprimeCursosDoWhile(Escuela escuela)
        {
            int contador = 0;
            do
            {
                Console.WriteLine($"Curso:{escuela.Cursos[contador].Nombre} ID:{escuela.Cursos[contador].ID} Jornada:{escuela.Cursos[contador].Jornada}");
            } while (++contador < escuela.Cursos.Length);
        }


        private static void ImprimeCursosFor(Escuela escuela)
        {
            for(int i=0; i<escuela.Cursos.Length; i++)
            {
                Console.WriteLine($"Curso:{escuela.Cursos[i].Nombre} ID:{escuela.Cursos[i].ID} Jornada:{escuela.Cursos[i].Jornada}");
            }
        }

        private static void ImprimeCursosForEach(Escuela escuela)
        {
            foreach(Curso item in escuela.Cursos)
            {
                Console.WriteLine($"Curso:{item.Nombre} ID:{item.ID} Jornada:{item.Jornada}");
            }
        }

    }
}
