namespace ConsoleDrawer {
    public class Cuadrado : Figura, IFigura {

        public Cuadrado(string name, int fila, int columna) : base(name, fila, columna) {}
        public override void Dibujar() {}
    }
}