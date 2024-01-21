using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace POO3
{
    public class Automovil:Vehiculo
    {
        private int _cantidadPuertas;

        public Automovil(string marca, string modelo, int anio, int cantidadPuertas)
            : base(marca, modelo, anio)
        {
            CantidadPuertas = ValidatePuertas(cantidadPuertas);
        }

        public int CantidadPuertas { get => _cantidadPuertas; set => _cantidadPuertas = ValidatePuertas(value); }

        private int ValidatePuertas(int cantidadPuertas)
        {
            if (cantidadPuertas < 2 || cantidadPuertas > 5)
            {
                throw new ArgumentException("El número de puertas no es válido");
            }
            return cantidadPuertas;
        }

        public override string RunAction()
        {
            string texto = "Conducir automóvil";
            return texto;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" + ". Tiene " + _cantidadPuertas + " puertas\n" +
                   $"Acción a tomar.......{RunAction()}\n\t";
        }

     }
}
