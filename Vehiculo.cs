using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace POO3
{
    public abstract class Vehiculo
    {
        private String _marca;
        private String _modelo;
        private int _anio;
        
        public Vehiculo(string marca, string modelo, int anio)
        {
            _marca = marca;
            _modelo = modelo;
            _anio = ValidateYear(anio);
        }

        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public int Anio { get => _anio; set => _anio = ValidateYear(value); }

        public abstract string RunAction();
        
        private int ValidateYear(int year)
        {
            if (year < 1886)
            {
                throw new ArgumentException("Este año no es válido");
            }
            return year;
        }

        
        public override string ToString()
        {
            return "Marca: " + _marca + ", Modelo: " + _modelo + ", Año " + _anio;
        }
    }
}
