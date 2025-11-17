using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Innovatec.Estructura
{
    public class NodoArbol
    {
        public int Id;
        public string Nombre;
        public List<NodoArbol> Hijos;
        public NodoArbol(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            Hijos = new List<NodoArbol>();
        }
    }

    public class ArbolGeneral
    {
        public NodoArbol Raiz;

        public void CrearRaiz(int id, string nombre)
        {
            Raiz = new NodoArbol(id, nombre);
        }

        public NodoArbol BuscarPorId(int id)
        {
            if (Raiz == null) return null;
            return BuscarRec(Raiz, id);
        }

        private NodoArbol BuscarRec(NodoArbol nodo, int id)
        {
            if (nodo.Id == id) return nodo;
            foreach (var h in nodo.Hijos)
            {
                var r = BuscarRec(h, id);
                if (r != null) return r;
            }
            return null;
        }

        public bool Insertar(int padreId, int id, string nombre)
        {
            if (Raiz == null)
            {
                if (padreId == -1)
                {
                    CrearRaiz(id, nombre);
                    return true;
                }
                return false;
            }

            var padre = BuscarPorId(padreId);
            if (padre == null) return false;
            if (BuscarPorId(id) != null) return false;

            padre.Hijos.Add(new NodoArbol(id, nombre));
            return true;
        }

        public void RecorrerPreorden(NodoArbol nodo, ListBox lista, int nivel = 0)
        {
            if (nodo == null) return;
            lista.Items.Add(new string(' ', nivel * 2) + $"[{nodo.Id}] {nodo.Nombre}");
            foreach (var h in nodo.Hijos)
                RecorrerPreorden(h, lista, nivel + 1);
        }

        public int ContarNodos()
        {
            return ContarRec(Raiz);
        }

        private int ContarRec(NodoArbol nodo)
        {
            if (nodo == null) return 0;
            int c = 1;
            foreach (var h in nodo.Hijos) c += ContarRec(h);
            return c;
        }

        public Dictionary<int, int> ObtenerNiveles()
        {
            var dict = new Dictionary<int, int>();
            if (Raiz == null) return dict;

            Queue<Tuple<NodoArbol, int>> q =
                new Queue<Tuple<NodoArbol, int>>();

            q.Enqueue(new Tuple<NodoArbol, int>(Raiz, 0));

            while (q.Count > 0)
            {
                var data = q.Dequeue();
                var n = data.Item1;
                var lvl = data.Item2;

                dict[n.Id] = lvl;

                foreach (var h in n.Hijos)
                    q.Enqueue(new Tuple<NodoArbol, int>(h, lvl + 1));
            }
            return dict;
        }
    }
}
