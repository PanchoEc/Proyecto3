using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    public class Camioneta:Vehiculo
    {
        private int _capacidadCarga;

        public Camioneta(string marca, string modelo, int anio, int capacidadCarga)
            : base(marca, modelo, anio)
        {
            CapacidadCarga = ValidateCarga(capacidadCarga);
        }

        public int CapacidadCarga { get => _capacidadCarga; set => _capacidadCarga = ValidateCarga(value); }

        private int ValidateCarga(int capacidadCarga)
        {
            if (capacidadCarga < 1000 || capacidadCarga > 2000)
            {
                throw new ArgumentException("La capacidad de carga no es válida");
            }
            return capacidadCarga;
        }

                        
        public override string RunAction()
        {
            string texto = "Cargar camioneta";
            return texto;
        }
                
        public override string ToString()
        {
            return $"{base.ToString()}" + ". Tiene una capacidad de carga de " + _capacidadCarga + " libras\n" +
                   $"Acción a tomar.......{RunAction()}\n\t";
        }

        

    }
}
