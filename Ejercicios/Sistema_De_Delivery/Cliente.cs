using System;
public class Cliente
{
    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public string Direccion { get; set; }

    public string Ciudad { get; set; }

    public string numeroContacto { get; set; }

    public string correoElectronico { get; set; }

    public void datosCliente()
    {
        Console.WriteLine("«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»««»«»«»«»«»«»«»«»«»«»«»«»«»«");
        Console.WriteLine("                ...Creacion de Pedido...");
        Console.WriteLine("Para realizar su pedido complete la siguiente informacion:");
        Console.WriteLine("«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»««»«»«»«»«»«»«»«»«»«»«»«»«»«");
        Console.WriteLine("");

        Console.WriteLine("Ingrese su Nombre: ");
        Nombre = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Ingrese su Apellido: ");
        Apellido = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Ingrese su Direccion: ");
        Direccion = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Ingrese la Ciudad donde reside: ");
        Ciudad = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Ingrese su Numero de contacto: ");
        numeroContacto = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Ingrese su Corrreo electronico: ");
        correoElectronico = Console.ReadLine();

        
    }
    
}