using System;
using Escuelita.Entidades;
using Escuelita.Util;

namespace Escuelita
{
    class Program
    {
        static void Main(string[] args)
        {
            Escuela objEscuela = new Escuela("COBAEP", "México", "Puebla", 1983);
            /* Printer.WriteLinea(objEscuela.ToString().Length);
            Console.WriteLine(objEscuela);
            Printer.WriteLinea(objEscuela.ToString().Length); */
            Printer.Titulo(objEscuela.ToString());



            objEscuela.Cursos = new Curso[3]
            {
                 new Curso() { Nombre = "101" },
                 new Curso() { Nombre = "201", Jornada = TipoJornada.Noche },
                 new Curso() { Nombre = "301" }
            };

            //objEscuela.Cursos = null;
            Printer.Titulo("Cursos de la Escuela");
            ImprimeCursosForEach(objEscuela);

        }



        private static void ImprimeCursosForEach(Escuela escuela)
        {
            if (escuela?.Cursos != null)
            foreach (Curso item in escuela.Cursos)
            {
                Console.WriteLine($"Curso:{item.Nombre} ID:{item.ID} Jornada:{item.Jornada}");
            }
        }

    }
}
