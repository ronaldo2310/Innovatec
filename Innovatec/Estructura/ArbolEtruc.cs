using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Innovatec.Estructura
{
    /// <summary>
    /// Representa un nodo dentro de un árbol general.
    /// Contiene un ID, un nombre y una lista de hijos.
    /// </summary>
    public class NodoArbol
    {
        /// <summary>ID único del nodo.</summary>
        public int Id;

        /// <summary>Nombre o etiqueta del nodo.</summary>
        public string Nombre;

        /// <summary>Lista de nodos hijos pertenecientes a este nodo.</summary>
        public List<NodoArbol> Hijos;

        /// <summary>
        /// Constructor del nodo del árbol.
        /// </summary>
        /// <param name="id">Identificador del nodo.</param>
        /// <param name="nombre">Nombre descriptivo del nodo.</param>
        public NodoArbol(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            Hijos = new List<NodoArbol>();
        }
    }

    /// <summary>
    /// Implementa un árbol general con operaciones básicas:
    /// insertar, buscar, recorrer y contar.
    /// </summary>
    public class ArbolGeneral
    {
        /// <summary>
        /// Nodo raíz del árbol. Puede ser nulo si el árbol está vacío.
        /// </summary>
        public NodoArbol Raiz;

        /// <summary>
        /// Crea la raíz del árbol con el ID y nombre proporcionados.
        /// </summary>
        public void CrearRaiz(int id, string nombre)
        {
            Raiz = new NodoArbol(id, nombre);
        }

        /// <summary>
        /// Busca un nodo dentro del árbol por su ID.
        /// </summary>
        /// <param name="id">ID a buscar.</param>
        /// <returns>Nodo encontrado o null si no existe.</returns>
        public NodoArbol BuscarPorId(int id)
        {
            if (Raiz == null) return null;
            return BuscarRec(Raiz, id);
        }

        /// <summary>
        /// Método recursivo auxiliar para buscar un nodo por ID.
        /// </summary>
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

        /// <summary>
        /// Inserta un nodo como hijo de un nodo padre.
        /// </summary>
        /// <param name="padreId">ID del padre donde se insertará.</param>
        /// <param name="id">ID del nuevo nodo.</param>
        /// <param name="nombre">Nombre del nuevo nodo.</param>
        /// <returns>True si la inserción fue exitosa; false en caso contrario.</returns>
        public bool Insertar(int padreId, int id, string nombre)
        {
            // Si el árbol está vacío, solo se puede crear la raíz.
            if (Raiz == null)
            {
                if (padreId == -1)
                {
                    CrearRaiz(id, nombre);
                    return true;
                }
                return false;
            }

            // Buscar padre.
            var padre = BuscarPorId(padreId);
            if (padre == null) return false;

            // Evitar duplicación de IDs.
            if (BuscarPorId(id) != null) return false;

            // Insertar nodo.
            padre.Hijos.Add(new NodoArbol(id, nombre));
            return true;
        }

        /// <summary>
        /// Realiza un recorrido en preorden desde un nodo,
        /// mostrando los resultados en un ListBox.
        /// </summary>
        /// <param name="nodo">Nodo actual.</param>
        /// <param name="lista">ListBox donde se imprimirá el resultado.</param>
        /// <param name="nivel">Nivel de profundidad (para sangría).</param>
        public void RecorrerPreorden(NodoArbol nodo, ListBox lista, int nivel = 0)
        {
            if (nodo == null) return;

            // Mostrar el nodo con sangría según el nivel.
            lista.Items.Add(new string(' ', nivel * 2) + $"[{nodo.Id}] {nodo.Nombre}");

            // Recorrer hijos.
            foreach (var h in nodo.Hijos)
                RecorrerPreorden(h, lista, nivel + 1);
        }

        /// <summary>
        /// Cuenta el total de nodos del árbol.
        /// </summary>
        public int ContarNodos()
        {
            return ContarRec(Raiz);
        }

        /// <summary>
        /// Método recursivo auxiliar para contar nodos.
        /// </summary>
        private int ContarRec(NodoArbol nodo)
        {
            if (nodo == null) return 0;

            int c = 1; // contar el nodo actual

            foreach (var h in nodo.Hijos)
                c += ContarRec(h);

            return c;
        }

        /// <summary>
        /// Obtiene un diccionario donde:
        /// clave = ID del nodo,
        /// valor = nivel del nodo dentro del árbol.
        /// </summary>
        public Dictionary<int, int> ObtenerNiveles()
        {
            var dict = new Dictionary<int, int>();
            if (Raiz == null) return dict;

            Queue<Tuple<NodoArbol, int>> q =
                new Queue<Tuple<NodoArbol, int>>();

            // Agregar la raíz con nivel 0.
            q.Enqueue(new Tuple<NodoArbol, int>(Raiz, 0));

            while (q.Count > 0)
            {
                var data = q.Dequeue();
                var n = data.Item1;
                var lvl = data.Item2;

                // Registrar nivel del nodo.
                dict[n.Id] = lvl;

                // Agregar hijos con nivel + 1.
                foreach (var h in n.Hijos)
                    q.Enqueue(new Tuple<NodoArbol, int>(h, lvl + 1));
            }

            return dict;
        }
    }
}
