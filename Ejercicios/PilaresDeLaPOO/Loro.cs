using System;
namespace Pilares
{
    public class Loro: Aves
    {
        public void NombreLoro(){
        Console.WriteLine("Se llama Pancracio");
    }
        public void Hablar(){
            Console.WriteLine("...Pasa hablando todo el dia...");
        }

        private void AlimentacionDomestica(){
            Console.WriteLine("...Semillas de Girasol...");
        }
        
    }
}