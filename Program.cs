using System;

namespace ConsoleDrawer
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Nuevo dibujo");
            Console.WriteLine("2 - Salir");

            var opcion = DrawMenu();
            while (!opcion) {
                opcion = DrawMenu();
            }

        }

        static bool DrawMenu() {
            var info = Console.ReadKey();
            if (info.KeyChar == '1') {
                var dibujo = new Dibujo();
                dibujo.Dibujar();
                Console.Read();
                return true;
            }
            else if (info.KeyChar == '2') {
                return true;
            }
            else {
                Console.WriteLine("Seleccione 1 ó 2");
                return false;
            }
        }
    }
}
