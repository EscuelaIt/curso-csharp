
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleDrawer {
    public class Dibujo {
        private Lista<IFigura> _figuras;

        public Dibujo() {
            _figuras = new Lista<IFigura>(10);
            _figuras.Add(new Texto(10, 5, "Hola a todos"));
            _figuras.Add(new Cuadrado(2, 10));

            var arr = new[] {1,2,4,6,2,4,10};
            arr.OrderBy(x => x).Take(2).Sum()

        }

        public void Dibujar() {
            foreach (var figura in _figuras) {
                figura?.Dibujar();
            }
        }

    }
}