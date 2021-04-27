using System;

public class Pago : Tarjeta
{

    public double Efectivo { get; set; }

    public void realizarPago()
    {
       string opcionPago = "";

    Console.WriteLine(" Ingrese la forma con la cual desea realizar su pago: ");
    Console.WriteLine("");
    Console.WriteLine(" 1. Tarjeta de Debito");
    Console.WriteLine(" 2. Tarjeta de Credito");
    Console.WriteLine(" 3. Efectivo");
    opcionPago = Console.ReadLine();

    if (opcionPago == "1")
    {       Console.Clear();
            Console.WriteLine("Pago con Tarjeta de Credito");
            Console.WriteLine("*******************************");
            Console.WriteLine("Ingrese nombre del Propietario");
            nombredelPropietarioC = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ingrese numero de tarjeta");
            numTarjetadeCredito = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ingrese Codigo de Verificacion de su tarjeta");
            string codigodeVerificacionC = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("¡¡Gracias por su compra!!");
            Console.WriteLine("");
            Console.WriteLine("Se ha enviado un mensaje a su correo para verificar que usted ha realizado esta accion");
            Console.ReadLine();

        }if (opcionPago == "2")
        {
            Console.Clear();
            Console.WriteLine("Pago con Tarjeta de Debito");
            Console.WriteLine("*******************************");
            Console.WriteLine("Ingrese nombre del Propietario");
            nombredelPropietarioD = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ingrese numero de tarjeta");
            numTarjetadeDebito = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ingrese Codigo de Verificacion de su tarjeta");
            string codigodeVerificacionD = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("¡¡Gracias por su compra!!");
            Console.WriteLine("");
            Console.WriteLine("Se ha enviado un mensaje a su correo para verificar que usted ha realizado esta accion");
            Console.ReadLine();

        }else if (opcionPago == "3")
        {
            Console.Clear();
            Console.WriteLine("Pago con Efectivo");
            Console.WriteLine("**********************");
            Console.WriteLine("Ingrese monto a Pagar");
            string Efectivo = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("¡¡Gracias por su compra!!");
             Console.WriteLine("");
            Console.WriteLine("Se ha enviado un mensaje a su correo para verificar que usted ha realizado esta accion");
            Console.ReadLine();
        }
         
    } 
}