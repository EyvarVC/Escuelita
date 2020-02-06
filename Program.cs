using System;
using Escuelita.Entidades;

namespace Escuelita
{
    class Program
    {
        static void Main(string[] args)
        {
            Escuela objEscuela = new Escuela("COBAEP","México","Puebla",1983);
            Console.WriteLine(objEscuela);
            
        }
    }
}
