public class DetallePedidos{
    public int Codigo { get; set; }

    public int Cantidad { get; set; }

    public double Precio { get; set; }

    public Productos Productos { get; set; }

    public DetallePedidos(int codigo, int cantidad, Productos productos)
    {
        Codigo = codigo;
        Cantidad = cantidad;
        Precio = productos.Precio;
        Productos = productos;

    }
    
}