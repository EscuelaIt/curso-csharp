using System;
using System.Dynamic;

namespace ConsoleDrawer
{

    class X {
        public string Name {
            get {
                return "X";
            }
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            dynamic d = new ExpandoObject();
            d.Name = "Hola";
            d.Age = 10;

            Console.WriteLine($"Hola soy {d.Name} y tengo {d.Age} años");

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

                dibujo.AddFigura(FiguraFactory.Instance.GetTexto("Hola", 10, 10));
                dibujo.AddFigura(FiguraFactory.Instance.GetCuadrado( 1, 3));

                dibujo.Save("drawing.json");

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
