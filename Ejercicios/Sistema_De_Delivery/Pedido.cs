using System;
using System.Collections.Generic;
public class Pedido
{
    public DateTime Fecha { get; set; }

    public int Codigo { get; set; }

    public List<DetallePedidos> ListaDetallePedidos { get; set; }
   
    public double subTotal { get; set; }

    public double tarifaEnvio { get; set; }
    
    public double Total { get; set; }

    public Cliente Cliente { get; set; }

    public List<Cliente> ListaCliente { get; set; }
    
    public Pedido(int codigo, DateTime fecha)
    {
     Codigo = codigo;
     Fecha = fecha;

     ListaDetallePedidos = new List<DetallePedidos>();
     ListaCliente = new List<Cliente>();
    }
 
    public void AgregarProductos (Productos productos)
    {
        int CodigoNuevo = ListaDetallePedidos.Count +1;
        int cantidad = 1;       
        double tarifEnvio = 80;

        DetallePedidos p = new DetallePedidos(CodigoNuevo, 1, productos);
        ListaDetallePedidos.Add(p);

        subTotal += cantidad * productos.Precio;
        tarifaEnvio = tarifEnvio;
        Total = subTotal + tarifEnvio;
    }
    
}