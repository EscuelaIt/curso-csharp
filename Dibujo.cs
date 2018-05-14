
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;


namespace ConsoleDrawer {
    public class Dibujo {
        private readonly List<IFigura> _figuras;

        public Dibujo() {
            _figuras = new List<IFigura>(10);
        }

        public IFigura this[string name] {
            get {
                return _figuras.FirstOrDefault(x => x.Name == name );
            }
        }

        public IEnumerable<string> Names {
            get {
                return _figuras
                    .OrderBy(f => f.Name)
                    .Select(f => f.Name);
            }
        }

        public IEnumerable<IFigura> Figuras {
            get {
                return _figuras;
            }
        }

        public T GetByName<T>(string name, T t) 
            where T : class, IFigura
         {
            return this[name] as T;
        }

        public void AddFigura(IFigura figura) {
            _figuras.Add(figura);
        }

        public void Dibujar() {
            foreach (var figura in _figuras) {
                figura?.Dibujar();
            }
        }

        public void Save(string path) {
            var cuadrados = _figuras.OfType<Cuadrado>();
            var textos = _figuras.OfType<Texto>();

            var resultado = new {
                Cuadrados = cuadrados,
                Textos = textos,
                Count = _figuras.Count
            };

            var json = JsonConvert.SerializeObject(resultado);
            File.WriteAllText(path, json);
        }

    }
}