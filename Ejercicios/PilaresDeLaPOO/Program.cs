using System;

namespace Pilares
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro p = new Perro();
            p.Nombre = "Scrapy";
            p.Patas = 4;
            p.ColordePelaje = "Cafe";
            p.TipodeOjos= "Redondos";
            p.HaceAcrobacias = true;

            Console.WriteLine("");
            Console.WriteLine("-----------PERRO----------");
            Console.WriteLine("El nombre es: " + p.Nombre);
            Console.WriteLine("Tiene ojos " + p.TipodeOjos);
            p.Dormir();
            p.Ladrar();
            p.Gruñir();

            Gato g = new Gato();
            g.Nombre = "Tom";
            g.Patas = 4;
            g.ColordePelaje = "Amarillo";
            g.TipodeOjos = "Ovalados";

            Console.WriteLine("");
            Console.WriteLine("-------------GATO--------------");
            Console.WriteLine("El nombre es: " + g.Nombre);
            Console.WriteLine("Tiene ojos " + g.TipodeOjos);
            g.Dormir();
            g.Maullar();
            g.Ronronear();

            Mono m = new Mono();
            m.Nombre = "Ursulo";
            m.Patas = 4;
            m.ColordePelaje = "Negro";
            m.TipodeOjos = "Redondos grandes"; 

            Console.WriteLine("");
            Console.WriteLine("-----------MONO-----------");
            Console.WriteLine("El nombre es: " + m.Nombre);
            Console.WriteLine("Tiene ojos " + m.TipodeOjos);
            Console.WriteLine("Tiene  " + m.Patas + " Patas");
            m.Saltar();

            Aguila a = new Aguila();
            a.Tipo = "Aguila Harpia";
            a.Pico = "Puntiagudo";
            a.ColorPlumaje = "Gris";
            a.Reproduccion = "Ovipara";

            Console.WriteLine("");
            Console.WriteLine("-----------AGUILA-----------");
            a.VolarAlto();
            Console.WriteLine("El tipo es: " + a.Tipo);
            Console.WriteLine("Tiene Pico " + a.Pico);
            Console.WriteLine("Tiene Plumaje de Color " + a.ColorPlumaje);
        
            Loro l = new Loro();
            Console.WriteLine("");
            Console.WriteLine("-----------LORO-----------");
            l.NombreLoro();
            l.Hablar();

            PezGlobo pg = new PezGlobo();
            Console.WriteLine("");
            Console.WriteLine("-----------PEZ GLOBO-----------");
            pg.NumeroAletas = 2;
            pg.ArcosBranquiales = 5;
            Console.WriteLine("Numero de aletas: " + pg.NumeroAletas);
            Console.WriteLine("Tiene " + pg.ArcosBranquiales + " Arcos Bronquiales");

        }
    }
}
