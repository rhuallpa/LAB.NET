using System;

namespace ConsoleAppHuallpa
{
    class Program
    {
        static void Main(string[] args)
        {
            Grifo grifo = new Grifo(); // Creamos un objeto de tipo Grifo para almacenar los usuarios

            bool ejecutando = true;
            while (ejecutando)
            {
                Console.WriteLine("Seleccione una acción:");
                Console.WriteLine("1. Mostrar información de usuarios");
                Console.WriteLine("2. Agregar cliente");
                Console.WriteLine("3. Agregar empleado");
                Console.WriteLine("4. Salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Información de usuarios:");
                        grifo.MostrarUsuarios();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese nombre del cliente:");
                        string nombreCliente = Console.ReadLine();
                        Console.WriteLine("Ingrese saldo del cliente:");
                        double saldoCliente = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese litros cargados del cliente:");
                        double litrosCargados = double.Parse(Console.ReadLine());
                        Cliente cliente = new Cliente(nombreCliente, saldoCliente, litrosCargados);
                        grifo.AgregarUsuario(cliente);
                        Console.WriteLine("Cliente agregado correctamente.");
                        break;
                    case 3:
                        Console.WriteLine("Ingrese nombre del empleado:");
                        string nombreEmpleado = Console.ReadLine();
                        Console.WriteLine("Ingrese saldo del empleado:");
                        double saldoEmpleado = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese sueldo del empleado:");
                        double sueldoEmpleado = double.Parse(Console.ReadLine());
                        Empleado empleado = new Empleado(nombreEmpleado, saldoEmpleado, sueldoEmpleado);
                        grifo.AgregarUsuario(empleado);
                        Console.WriteLine("Empleado agregado correctamente.");
                        break;
                    case 4:
                        ejecutando = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
