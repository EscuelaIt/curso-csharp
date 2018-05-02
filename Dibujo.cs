
namespace ConsoleDrawer {
    public class Dibujo {
        private Lista _figuras;

        public Dibujo() {
            _figuras = new Lista(10);
            _figuras.Add(new Texto(10, 5, "Hola a todos"));
        }

        public void Dibujar() {
            /*
            foreach (var figura in _figuras) {
                figura?.Dibujar();
            }
            */
            for (var idx = 0; idx < _figuras.Count; idx++) {

                var figura = _figuras.GetAt(idx) as Figura;
                figura.Dibujar();
            }
        }

    }
}