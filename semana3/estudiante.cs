public class Estudiante : Persona
{
    public int Codigo { get; set; }
    public string[] Telefonos { get; set; }

    public Estudiante(int codigo, string nombres, string apellidos, string direccion, string[] telefonos)
        : base(nombres, apellidos, direccion)
    {
        Codigo = codigo;
        Telefonos = telefonos;
    }

    public void VerDetalles()
    {
        Console.WriteLine("\n=== Datos del Estudiante ===");
        Console.WriteLine($"ID: {Codigo}");
        Console.WriteLine($"Nombre: {Nombres} {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("Teléfonos de contacto:");
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($"{i + 1}: {Telefonos[i]}");
        }
    }
}
