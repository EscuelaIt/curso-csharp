
using System;
using System.Collections.Generic;

namespace ConsoleDrawer {
    public class Dibujo {
        private Lista<IFigura> _figuras;

        public Dibujo() {
            _figuras = new Lista<IFigura>(10);
            _figuras.Add(new Texto(10, 5, "Hola a todos"));
            _figuras.Add(new Cuadrado(2, 10));

        }

        public void Dibujar() {
            foreach (var figura in _figuras) {
                figura?.Dibujar();
            }
        }

    }
}