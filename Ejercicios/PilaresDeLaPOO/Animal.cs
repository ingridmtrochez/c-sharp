using System;
namespace Pilares
{
    public abstract class Animal
    {
        public string Nombre { get; set; }

        public void Comer(){

        }

        public void Dormir(){
            Console.WriteLine("Le gusta dormir mucho!");
        }
    }
}