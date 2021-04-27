using System;

namespace Sistema_De_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Proceso pro = new Proceso();
            string opcion = "";
            while (true){

            Console.Clear();
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.WriteLine("«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»««»««»«»«»«»«»«»«»«»«»«»«»");
            Console.WriteLine("«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»««»««»«»«»«»«»«»«»«»«»«»«»");
            Console.WriteLine("");
            Console.WriteLine("     °        / °°°°° °°°°°   /°    |      °°°°° °°°°° °  /");
            Console.WriteLine("      °      /    |     |    /--°   |        |     |    °/ ");
            Console.WriteLine("       °    /     |     |   /    °  |        |     |    /  ");
            Console.WriteLine("         ° /    °°°°°      /      ° °°°°°  °°°°°       °   ");
            Console.WriteLine("                                                     °    ");
            Console.WriteLine("");
            Console.WriteLine("«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»««»««»«»«»«»«»«»«»«»«»«»«»");
            Console.WriteLine("«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»««»««»«»«»«»«»«»«»«»«»«»«»");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("               BIENVENIDA(O) A NUESTRO SISTEMA DE DELIVERY");
            Console.WriteLine("  TU ELIJE EL OUTFIT PERFECTO,NOSOTROS TE TENEMOS ¡EL MAQUILLAJE IDEAL!");
            Console.WriteLine("«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»««»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»");
            Console.WriteLine("«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»««»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»«»");
            Console.WriteLine("");
            Console.WriteLine("  MENU");
            Console.WriteLine("");
            Console.WriteLine("  1 - Productos y Precio");
            Console.WriteLine("  2 - Realizar Pedidos");
            Console.WriteLine("  3 - Forma de Pago");
            Console.WriteLine("  4 - Factura Cliente");
            Console.WriteLine("  0 - Salir");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Clear();
                    pro.listarProductos();
                break;

                case "2":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Clear();
                    pro.crearPedido();
                    break;

                case "3":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Clear();
                    pro.Pagar();
                    break;
                
                case "4":
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    pro.generarFactura();
                    break;
                default:
                break;
            }
            if(opcion == "0")
            {
                break;
            }
            }
            
        }
    }
}
