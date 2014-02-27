using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Daniel", "12345");
            Persona persona2 = new Persona("Mario", "12342");
            Agenda agenda = new Agenda();

            agenda.agregar(persona1);
            agenda.agregar(persona2);

            agenda.mostrar();

            agenda.buscar("Dahniel");
            Console.WriteLine("-----");
            agenda.eliminar("Marios");
            agenda.mostrar();
            Console.ReadKey();
        }
    }
}
