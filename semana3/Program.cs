using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine(">> Sistema de Registro Estudiantil <<");

            Console.Write("Ingrese el código del estudiante: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese los nombres: ");
            string nombres = Console.ReadLine();

            Console.Write("Ingrese los apellidos: ");
            string apellidos = Console.ReadLine();

            Console.Write("Ingrese la dirección: ");
            string direccion = Console.ReadLine();

            string[] telefonos = new string[3];
            for (int i = 0; i < telefonos.Length; i++)
            {
                Console.Write($"Teléfono {i + 1}: ");
                telefonos[i] = Console.ReadLine();
            }

            Estudiante nuevoEstudiante = new Estudiante(codigo, nombres, apellidos, direccion, telefonos);
            nuevoEstudiante.VerDetalles();
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nHa ocurrido un error en el registro.");
            Console.WriteLine($"Detalles: {ex.Message}");
        }
    }
}
