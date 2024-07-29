using System;

class CajeroAutomatico
{
    static void Main()
    {
        const string contrasenaCorrecta = "1234"; // Contraseña de acceso
        string contrasenaIngresada;

        // Solicitar la contraseña al usuario
        Console.Write("Ingrese la contraseña para acceder al Cajero Automático: ");
        contrasenaIngresada = Console.ReadLine();

        // Verificar la contraseña
        if (contrasenaIngresada != contrasenaCorrecta)
        {
            Console.WriteLine("Contraseña incorrecta. Acceso denegado.");
            return; // Salir del programa si la contraseña es incorrecta
        }

        double saldo = 1000.00; // Saldo inicial
        int opcion;

        do
        {
            // Mostrar el menú de opciones
            Console.WriteLine("\nBienvenido al Cajero Automático");
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Retirar dinero");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción (1-3): ");

            // Leer la opción del usuario
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Consultar saldo
                    Console.WriteLine($"Su saldo actual es: ${saldo:F2}");
                    break;
                case 2:
                    // Retirar dinero
                    Console.Write("Ingrese la cantidad que desea retirar: ");
                    double cantidadRetiro = Convert.ToDouble(Console.ReadLine());

                    if (cantidadRetiro <= saldo)
                    {
                        saldo -= cantidadRetiro; // Actualizar saldo
                        Console.WriteLine($"Ha retirado: ${cantidadRetiro:F2}");
                        Console.WriteLine($"Su nuevo saldo es: ${saldo:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente para realizar esta operación.");
                    }
                    break;
                case 3:
                    // Salir
                    Console.WriteLine("Gracias por utilizar el Cajero Automático. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción entre 1 y 3.");
                    break;
            }

            Console.WriteLine(); // Línea en blanco para mejorar la legibilidad

        } while (opcion != 3); // Continuar hasta que el usuario elija salir
    }
}
