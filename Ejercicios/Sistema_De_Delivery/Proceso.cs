using System;
using System.Collections.Generic;

public class Proceso 
{
    public List<Productos> ListadeProductos { get; set; }

    public List<Pedido> ListaPedidos { get; set; }

    Pago pago = new Pago();

    Cliente cliente = new Cliente();

    public Proceso()
    {
       ListadeProductos = new List<Productos>();
       cargarProductos();

       ListaPedidos = new List<Pedido>();

    }

    private void cargarProductos()
    {
     Productos p1 = new Productos(01, "Paleta de sombras de maquillaje", 130);
     ListadeProductos.Add(p1);

     Productos p2 = new Productos(02, "Base de maquillaje y corrector",  350);
     ListadeProductos.Add(p2);

     Productos p3 = new Productos(03, "Crema hidratante e iluminador",   800);
     ListadeProductos.Add(p3);

     Productos p4 = new Productos(04, "Mascara de pestañas",              90);
     ListadeProductos.Add(p4);

     Productos p5 = new Productos(05, "Lapices de Labios",               100);
     ListadeProductos.Add(p5);

     Productos p6 = new Productos(06, "Brochas y cepillos",              300);
     ListadeProductos.Add(p6);

     Productos p7 = new Productos(07, "Iluminador",                      250);
     ListadeProductos.Add(p7);

     Productos p8 = new Productos(08, "Hisopos y toallitas faciales",    150);
     ListadeProductos.Add(p8);

     Productos p9 = new Productos(09, "Lapiz de cejas",                   80);
     ListadeProductos.Add(p9);

     Productos p10 = new Productos(10, "Polvo compacto",                220);
     ListadeProductos.Add(p10);

     Productos p11 = new Productos(11, "Correctores para ojeras",       160);
     ListadeProductos.Add(p11);

     Productos p12 = new Productos(12, "Blush o Bronzer",               300);
     ListadeProductos.Add(p12);
    }

    public void listarProductos()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("           Lista de Productos");
        Console.WriteLine("­­­­«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»««»««»");
        Console.WriteLine("");
        Console.WriteLine("Codigo|" + "     Descripcion     " + "    |Precio");
    
    foreach (var producto in ListadeProductos)
    {
        Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
    }
    Console.ReadLine();

    }

    public void crearPedido()
    {   
        cliente.datosCliente();

        int CodigoNuevo = ListaPedidos.Count +1;

        Pedido PedidoNuevo = new Pedido (CodigoNuevo, DateTime.Now);
        ListaPedidos.Add(PedidoNuevo);

        while (true)
    {
        Console.WriteLine("");
        Console.WriteLine("Ingrese el producto");
        string codigoProductos = Console.ReadLine();

        Productos productos = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProductos );
        if (productos == null)
        {
            Console.WriteLine("--No encontramos el producto que ingreso--");
            Console.WriteLine(" ");
        } else{
            Console.WriteLine(" ");
            Console.WriteLine("--Producto agregado-- : " + productos.Descripcion + " --- con precio de: " + productos.Precio + " lps--");
            PedidoNuevo.AgregarProductos(productos);
        }
        Console.WriteLine("");
        Console.WriteLine("Desea agregar otro producto? s/n | Ingrese s si desea agregar  | Ingrese n si dese terminar su pedido  ");
        string continuar = Console.ReadLine();
        if(continuar.ToLower() == "n")
        {
           break;
        }
         
    }
    Console.WriteLine("");
    Console.WriteLine("******************************");
    Console.WriteLine("SubTotal del pedido es de: " + PedidoNuevo.subTotal);
    Console.WriteLine("Tarifa de envio : " + PedidoNuevo.tarifaEnvio);
    Console.WriteLine("Total a pagar es: " + PedidoNuevo.Total + " Lps");
    Console.ReadLine();
    }

     public void generarFactura()
        { 
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("                                VITALITY");
            Console.WriteLine("*********************************************************************************");  
            Console.WriteLine("");
            Console.WriteLine(" E-mail: info@vitality.hn | Telefono: +504 2552 2854 | Sitio web: www.vitality.com");
            Console.WriteLine("");
            Console.WriteLine("                            Informacion Cliente");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Nombre     |Apellido     |Ciudad       |Direccion      |Contacto ");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine(""            + cliente.Nombre + " | " + cliente.Apellido + " | " + cliente.Ciudad + " | " + cliente.Direccion + " | " + cliente.numeroContacto ); 
            Console.WriteLine("");
            Console.WriteLine("                        Detalle de la factura");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Codigo|Fecha           |SubTotal|Tarifa de Envio|Total");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("");
            
            foreach (var Pedido in ListaPedidos)
            {
            Console.WriteLine(""+ Pedido.Codigo+"|"+ Pedido.Fecha +"|"+ Pedido.subTotal+"|"+ Pedido.tarifaEnvio+"|"+ Pedido.Total + " Lps" );
            Console.WriteLine("");
            
            Console.WriteLine("                         Detalle del pedido");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Descripcion            |Cantidad|Precio");  
         
           foreach (var Detalle in Pedido.ListaDetallePedidos)
            {
            Console.WriteLine("");  
            Console.WriteLine(      Detalle.Productos.Descripcion +     "   | "      + Detalle.Cantidad + " | "         + Detalle.Precio);
            }
            Console.WriteLine();
            }
            Console.ReadLine();
            Console.Clear();
        }    
        public void Pagar(){
            pago.realizarPago();
        }
}
