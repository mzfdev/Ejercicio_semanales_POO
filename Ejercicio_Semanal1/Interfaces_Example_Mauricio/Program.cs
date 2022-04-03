using System;

namespace Interfaces_Example_Mauricio
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Terrestre leopardo = new Terrestre("120 km/h");
            Acuatico tiburon = new Acuatico("56 km/h");
            Volador aguila = new Volador("160 km/h");

            leopardo.Correr();
            tiburon.Nadar();
            aguila.Volar();
            
            Console.WriteLine();
            
            //Utilizando el metodo cazar segun el objeto que se envia
            Cazando(leopardo);
            Cazando(tiburon);
            Cazando(aguila);
        }

        //Metodo que recibe una interfaz y dependiendo del objeto que reciba asi ejecutara el metodo
        static void Cazando(IDepredador depredador)
        {
            depredador.Cazar();
        }
    }
}