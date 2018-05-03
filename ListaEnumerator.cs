using System.Collections;
using System.Collections.Generic;

namespace ConsoleDrawer {
    // COMO REFERENCIA PQ NO SE USA
    public class ListaEnumerator<T> : IEnumerator<T>, IEnumerator
    {
        private int _idx;
        private readonly ILista<T> _lista;

        public ListaEnumerator (ILista<T> lista) {
            _lista = lista;
            _idx  = -1;
        }

        public T Current {
            get { return _lista.GetAt(_idx); }
        }

        object IEnumerator.Current  {
            get {
                return Current;
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            _idx++;
            return _idx < _lista.Count;
        }

        public void Reset()
        {
            _idx = 0;
        }
    }
}
