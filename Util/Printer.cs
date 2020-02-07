using static System.Console;

namespace Escuelita.Util


{
    public static class Printer
    {
        public static void WriteLinea(int veces = 10)
        {
            /* string linea="";
            for(int i=1; i<=veces;i++)
            {
                linea = linea + "=";

            } */

            //string linea = "".PadLeft(veces, '=');

            WriteLine("".PadLeft(veces, '='));

        }

        public static void Titulo(string Título)
        {
            int tamaño = Título.Length +4;

            WriteLinea(tamaño);
            WriteLine($"| {Título} |");
            WriteLinea(tamaño);
        }
    }
}