public class Persona
{
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Direccion { get; set; }

    public Persona(string nombres, string apellidos, string direccion)
    {
        Nombres = nombres;
        Apellidos = apellidos;
        Direccion = direccion;
    }
}
