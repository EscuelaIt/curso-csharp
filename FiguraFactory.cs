namespace ConsoleDrawer {
    public class FiguraFactory {
        
        private static FiguraFactory _instance;

        public static FiguraFactory Instance {
            get {return _instance;}
        }

        private  int _numCuadrados;
        private  int _numTextos;
    
        static FiguraFactory() {
            _instance = new FiguraFactory();
        }

        private  FiguraFactory()
        {
            _numCuadrados = 0;
            _numTextos = 0;
        }
        
        public   Cuadrado GetCuadrado(int fila, int columna) {
            var cuadrado =  new Cuadrado($"Cuadrado {_numCuadrados}", fila, columna);
            _numCuadrados = _numCuadrados+1;
            return cuadrado;
        }

        public  Texto GetTexto(string texto, int fila, int columna) {
            var textoFigura =  new Texto($"Texto {_numTextos}", fila, columna, texto);
            _numTextos = _numTextos + 1;
            return textoFigura;
        }
    }
}