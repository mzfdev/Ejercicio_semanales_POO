using System;

namespace Interfaces_Example_Mauricio
{
    public class Terrestre : IDepredador
    {
        private string velocidadAlCorrer;

        public Terrestre(string velocidadAlCorrer)
        {
            this.velocidadAlCorrer = velocidadAlCorrer;
        }

        public void Correr()
        {
            Console.WriteLine($"Este animal corre a una velodidad de: {velocidadAlCorrer}");
        }
        public void Cazar()
        {
            Console.WriteLine("Este animal caza por tierra");
        }
    }
}