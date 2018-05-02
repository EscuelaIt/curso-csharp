namespace ConsoleDrawer {
    public abstract class Figura : IFigura {

        public Posicion Pos {get; }


        public Figura (int fila, int columna) {
            Pos = new Posicion(fila,columna);
        }

        public abstract void Dibujar();

    }
}