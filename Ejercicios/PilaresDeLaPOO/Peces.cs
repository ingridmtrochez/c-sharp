using System;
namespace Pilares
{
    public abstract class Peces
    {

        public int NumeroAletas { get; set; }

        public int ArcosBranquiales { get; set; }

        public void Nadar(){
            Console.WriteLine("... Blu,Blu,Blu...");
        }
    }
}