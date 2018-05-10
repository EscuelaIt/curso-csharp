using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleDrawer {
    /*
    public class Lista {
        private readonly object[] _items;
        private readonly Type _type;
        public int Count {get; private set;}
        public Lista(int limit, Type type) {
            _items = new object[limit];
            Count =  0;
            _type = type;
        }

        public object GetAt(int idx) {
            return _items[idx];
        }

        public void Add (object item) {
            if (item.GetType().IsAssignableFrom(_type)) {
                throw new ArgumentException("Tipo " + item.GetType().Name + " no es válido");
            }

            if (Count == _items.Length) {
                throw new InvalidOperationException("Lista llena!");
            }
            _items[Count] = item;
            Count++;
        }
    }

     public class Lista<T> 
     {

         private readonly Lista _lista;

         public int Count {get {
                return _lista.Count;
            }
         }

         public Lista(int limit) {
             _lista = new Lista(limit, typeof(T));
         }

        public T GetAt(int idx) {
            return (T)_lista.GetAt(idx);
        }
        public void Add (T item) {
            _lista.Add(item);
        }
     }
    */

    public interface ILista {
        int Count {get;}
         object GetAt(int idx);
         void Add (object item);
    }

    public delegate bool PredicateDelegate<T>(T item);



    public interface ILista<T> : IEnumerable<T>
    {
        int Count {get;}
        T GetAt(int idx);
        void Add (T item);

        // IEnumerable<T> SearchByDelegate (PredicateDelegate<T> predicate);
        IEnumerable<T> SearchByDelegate (Func<T, bool> predicate);
        IEnumerable<T> FindPredicate (IPredicate<T> predicate);
    }

    public class Lista<T> : ILista<T>, ILista {
        private readonly T[] _items;
        public int Count {get; private set;}
        public Lista(int limit) {
            _items = new T[limit];
            Count =  0;
        }

        public T GetAt(int idx) {
            return _items[idx];
        }

        object ILista.GetAt(int idx) {
            return _items[idx];
        }

        void ILista.Add (object item) {
            Add((T)item);
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator() {
            foreach (var item in _items) {
                if (item != null) {
                    yield return item;
                }
            }
        }

        public void Add (T item) {
            if (Count == _items.Length) {
                throw new InvalidOperationException("Lista llena!");
            }
            _items[Count] = item;
            Count++;
        }

        public IEnumerable<T> FindPredicate (IPredicate<T> predicate) {
            foreach (var current in _items) {
                if (current != null && predicate.Match(current)) {
                    yield return current;
                }
            }
        }
        
         public IEnumerable<T> SearchByDelegate (Func<T, bool> predicate) {
             foreach (var current in _items) {
                if (current != null && predicate(current)) {
                    yield return current;
                }
            }            
         }
    }    
}