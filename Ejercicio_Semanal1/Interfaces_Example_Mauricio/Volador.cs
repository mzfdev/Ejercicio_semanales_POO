using System;

namespace Interfaces_Example_Mauricio
{
    public class Volador : IDepredador
    {
        private string velocidadAlVolar;

        public Volador(string velocidadAlVolar)
        {
            this.velocidadAlVolar = velocidadAlVolar;
        }

        public void Volar()
        {
            Console.WriteLine($"Este animal vuela a una velodidad de: {velocidadAlVolar}");
        }

        public void Cazar()
        {
            Console.WriteLine("Este animal caza por aire");
        }
    }
}