using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Persona
    {
        private string nombre;
        private string numero;

        public Persona()
        {

        }

        public Persona(string nombre, string numero)
        {
            this.nombre = nombre.ToLower();
            this.numero = numero.ToLower();
        }

        public string getNombre()
        {
            return this.nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNumero()
        {
            return this.numero;
        }

        public void setNumero(string numero)
        {
            this.numero = numero;
        }
    }
}
