namespace ConsoleDrawer {
    public abstract class Figura : IFigura {

        public Posicion Pos {get; }

        public string Name {get;}


        public Figura (string name, int fila, int columna) {
            Name = name;
            Pos = new Posicion(fila,columna);
        }

        public abstract void Dibujar();

    }
}