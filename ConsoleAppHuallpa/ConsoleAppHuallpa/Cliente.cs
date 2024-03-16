using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppHuallpa
{
    public class Cliente : Usuario
    {
        public double LitrosCargados { get; set; }

        // Constructor
        public Cliente(string nombre, double saldo, double litrosCargados) : base(nombre, saldo)
        {
            LitrosCargados = litrosCargados;
        }

        // Sobrescritura del método MostrarInformacion
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Saldo: {Saldo}, Litros Cargados: {LitrosCargados}");
        }
    }
}
