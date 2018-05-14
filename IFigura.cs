namespace ConsoleDrawer {
    public interface IFigura {
         string Name {get;}
         void Dibujar();
         Posicion Pos {get; }
    }
}