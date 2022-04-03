using System;

namespace Interfaces_Example_Mauricio
{
    public class Acuatico : IDepredador
    {
        private string velocidadAlNadar;

        public Acuatico(string velocidadAlNadar)
        {
            this.velocidadAlNadar = velocidadAlNadar;
        }

        public void Nadar()
        {
            Console.WriteLine($"Este animal nada a una velodidad de: {velocidadAlNadar}");
        }
        
        public void Cazar()
        {
            Console.WriteLine("Este animal caza por agua");
        }
    }
}