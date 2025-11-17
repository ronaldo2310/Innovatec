using System;
using System.Collections.Generic;

namespace Innovatec.Estructura
{
    /// <summary>
    /// Representa un grafo no dirigido y ponderado.
    /// Implementa operaciones para agregar nodos, agregar aristas,
    /// mostrar adyacencias, verificar conectividad y ejecutar Dijkstra.
    /// </summary>
    public class Grafo
    {
        /// <summary>
        /// Diccionario de adyacencia:
        /// clave = nombre del nodo,
        /// valor = lista de pares (nodo vecino, peso).
        /// </summary>
        public Dictionary<string, List<KeyValuePair<string, double>>> adj;

        /// <summary>
        /// Constructor: inicializa la estructura de adyacencias.
        /// </summary>
        public Grafo()
        {
            adj = new Dictionary<string, List<KeyValuePair<string, double>>>();
        }

        /// <summary>
        /// Agrega un nodo al grafo si no existe previamente.
        /// </summary>
        /// <param name="nodo">Nombre del nodo.</param>
        /// <returns>True si se agregó o si ya existía; false si era inválido.</returns>
        public bool AgregarNodo(string nodo)
        {
            if (string.IsNullOrWhiteSpace(nodo)) return false;

            nodo = nodo.Trim();

            // Si no está en el diccionario, se agrega con lista vacía.
            if (!adj.ContainsKey(nodo))
                adj[nodo] = new List<KeyValuePair<string, double>>();

            return true;
        }

        /// <summary>
        /// Agrega una arista no dirigida entre los nodos A y B con un peso.
        /// </summary>
        /// <param name="a">Nodo origen.</param>
        /// <param name="b">Nodo destino.</param>
        /// <param name="peso">Peso o costo de la arista.</param>
        /// <returns>True si se agregó; false si ya existía o si los nombres eran inválidos.</returns>
        public bool AgregarArista(string a, string b, double peso)
        {
            if (string.IsNullOrWhiteSpace(a) || string.IsNullOrWhiteSpace(b))
                return false;

            a = a.Trim();
            b = b.Trim();

            // Asegurar existencia de los nodos
            AgregarNodo(a);
            AgregarNodo(b);

            // Evitar duplicación de la arista
            if (adj[a].Exists(x => x.Key == b))
                return false;

            // Agregar arista en ambas direcciones (grafo no dirigido)
            adj[a].Add(new KeyValuePair<string, double>(b, peso));
            adj[b].Add(new KeyValuePair<string, double>(a, peso));

            return true;
        }

        /// <summary>
        /// Retorna una lista de todos los nodos del grafo.
        /// </summary>
        public List<string> Nodos()
        {
            return new List<string>(adj.Keys);
        }

        /// <summary>
        /// Devuelve una lista de strings describiendo las adyacencias de cada nodo.
        /// Ejemplo: A -> B(3), C(5)
        /// </summary>
        public List<string> MostrarAdyacencias()
        {
            var res = new List<string>();
            var keys = new List<string>(adj.Keys);

            keys.Sort(); // Orden alfabético para mostrar ordenado

            foreach (var k in keys)
            {
                var parts = new List<string>();

                // Construir texto de adyacencias con pesos
                foreach (var p in adj[k])
                    parts.Add(p.Key + "(" + p.Value + ")");

                res.Add(k + " -> " + string.Join(", ", parts));
            }

            return res;
        }

        /// <summary>
        /// Determina si el grafo es conexo usando un recorrido BFS.
        /// </summary>
        /// <returns>True si todos los nodos son alcanzables desde el primero.</returns>
        public bool EsConexo()
        {
            if (adj.Count == 0)
                return true; // Un grafo vacío se considera conexo

            var visit = new HashSet<string>();
            var q = new Queue<string>();

            // Tomar primer nodo del grafo como inicio
            var start = new List<string>(adj.Keys)[0];

            q.Enqueue(start);
            visit.Add(start);

            // BFS
            while (q.Count > 0)
            {
                var v = q.Dequeue();

                foreach (var nb in adj[v])
                {
                    if (!visit.Contains(nb.Key))
                    {
                        visit.Add(nb.Key);
                        q.Enqueue(nb.Key);
                    }
                }
            }

            return visit.Count == adj.Count;
        }

        /// <summary>
        /// Algoritmo de Dijkstra para hallar la distancia mínima y el camino
        /// entre dos nodos.
        /// </summary>
        /// <param name="origen">Nodo de inicio.</param>
        /// <param name="destino">Nodo de destino.</param>
        /// <returns>
        /// Una tupla donde:
        ///   Item1 = distancia mínima,
        ///   Item2 = lista de nodos del camino.
        /// </returns>
        public Tuple<double, List<string>> Dijkstra(string origen, string destino)
        {
            // Verificar existencia de los nodos
            if (!adj.ContainsKey(origen) || !adj.ContainsKey(destino))
                return new Tuple<double, List<string>>(double.PositiveInfinity, new List<string>());

            var dist = new Dictionary<string, double>();
            var prev = new Dictionary<string, string>();
            var q = new List<string>();

            // Inicializar estructuras
            foreach (var n in adj.Keys)
            {
                dist[n] = double.PositiveInfinity;
                prev[n] = null;
                q.Add(n);
            }

            dist[origen] = 0.0;

            // Bucle principal de Dijkstra
            while (q.Count > 0)
            {
                // Seleccionar nodo con menor distancia provisional
                q.Sort((x, y) => dist[x].CompareTo(dist[y]));
                var u = q[0];
                q.RemoveAt(0);

                // Si es infinito, no quedan caminos posibles
                if (double.IsInfinity(dist[u])) break;

                // Si llegamos al destino, podemos terminar
                if (u == destino) break;

                // Relajación de aristas
                foreach (var nb in adj[u])
                {
                    var v = nb.Key;
                    var peso = nb.Value;
                    var alt = dist[u] + peso;

                    if (alt < dist[v])
                    {
                        dist[v] = alt;
                        prev[v] = u;
                    }
                }
            }

            // No existe ruta
            if (double.IsInfinity(dist[destino]))
                return new Tuple<double, List<string>>(double.PositiveInfinity, new List<string>());

            // Reconstruir camino
            var camino = new List<string>();
            var cur = destino;

            while (cur != null)
            {
                camino.Add(cur);
                cur = prev[cur];
            }

            camino.Reverse();

            return new Tuple<double, List<string>>(dist[destino], camino);
        }
    }
}

