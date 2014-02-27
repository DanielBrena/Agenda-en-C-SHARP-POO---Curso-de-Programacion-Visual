using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Agenda
    {
        private List<Persona> agenda;

        public Agenda()
        {
            agenda = new List<Persona>();
        }

        public void agregar(Persona persona)
        {
            agenda.Add(persona);
        }

        public void mostrar()
        {
            foreach (Persona persona in agenda)
            {
                Console.WriteLine("{0} | {1} ",persona.getNombre(), persona.getNumero());
            }
        }

        public Boolean esta(string nombre)
        {
            Boolean esta = false;

            foreach (Persona persona in agenda)
            {
                if (persona.getNombre().Equals(nombre.ToLower()))
                {
                    esta = true;
                    break;
                }
                else
                {
                    esta = false;
                }
            }

            return esta;
        }

        public void buscar(string nombre)
        {
            
            if (this.esta(nombre.ToLower()))
            {
                foreach (Persona persona in agenda)
                {
                    if(persona.getNombre().Equals(nombre.ToLower()))
                    {
                        Console.WriteLine("Nombre: {0} \nNumero: {1} ", persona.getNombre(), persona.getNumero());
                    }
                }
               

            }
            else
            {
                Console.WriteLine("No se encontro contacto con el nombre de {0}.", nombre.ToLower());
            }


           // return persona;
        }

        public void eliminar(string nombre)
        {
            if (this.esta(nombre.ToLower()))
            {
                foreach (Persona persona in agenda)
                {
                    if (persona.getNombre().Equals(nombre.ToLower()))
                    {
                        this.getAgenda().Remove(persona);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("No se encontro contacto con el nombre {0} para eliminar.", nombre.ToLower());
            }
        }

        public List<Persona> getAgenda()
        {
            return this.agenda;
        }

        public void setAgenda(List<Persona> agenda)
        {
            this.agenda = agenda;

        }

    }
}
