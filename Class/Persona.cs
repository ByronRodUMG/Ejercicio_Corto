using Ejercicio_Corto.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Corto.Class
{
    internal class Persona : IPersona
    {
        public string Nombre { get; }

        public int Edad { get; }

        public void CumplirAños(int edad)
        {
            Console.WriteLine($"Tienes {edad} años, ya casi cumples {edad+1}.");
        }

        public void saludar()
        {
            Console.WriteLine($"Buenos días, {Nombre}.");
        }

        public Persona(int edad, string nombre)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
}
