using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppHuallpa
{
    public class Empleado : Usuario
    {
        public double Sueldo { get; set; }

        // Constructor
        public Empleado(string nombre, double saldo, double sueldo) : base(nombre, saldo)
        {
            Sueldo = sueldo;
        }

        // Sobrescritura del método MostrarInformacion 
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Saldo: {Saldo}, Sueldo: {Sueldo}");
        }
    }
}

