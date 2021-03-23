using System;
namespace Pilares
{
    public class Perro: Mamiferos //Herencia
    { 
        
        public bool HaceAcrobacias { get; set; } 
        public Perro()
        {
            HaceAcrobacias = true;
        }

        public Perro(bool haceAcrobacias) //Polimorfismo
        {
            HaceAcrobacias = haceAcrobacias;
        }
        
        //Abstracción
        public void Ladrar(){
           Console.WriteLine("Hace: Guau guau!");
        }

         public void Gruñir(){
          Console.WriteLine("Cuando se enoja hace: Grrrru Grrrru!");
        }
    
    
        //Encapsulamiento
        private void DeterminarPeso(){
           Console.WriteLine("Pequeños: 5-14 kilos");
           Console.WriteLine("Grandes: 25-50 kilos");
       }
    }
}
