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

            //objEscuela.Cursos = null;
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
