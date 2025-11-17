using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovatec.Estructura
{
    public class Grafo
    {
        public Dictionary<string, List<KeyValuePair<string, double>>> adj;

        public Grafo()
        {
            adj = new Dictionary<string, List<KeyValuePair<string, double>>>();
        }

        public bool AgregarNodo(string nodo)
        {
            if (string.IsNullOrWhiteSpace(nodo)) return false;
            nodo = nodo.Trim();
            if (!adj.ContainsKey(nodo))
                adj[nodo] = new List<KeyValuePair<string, double>>();
            return true;
        }

        public bool AgregarArista(string a, string b, double peso)
        {
            if (string.IsNullOrWhiteSpace(a) || string.IsNullOrWhiteSpace(b)) return false;
            a = a.Trim();
            b = b.Trim();
            AgregarNodo(a);
            AgregarNodo(b);
            if (adj[a].Exists(x => x.Key == b)) return false;
            adj[a].Add(new KeyValuePair<string, double>(b, peso));
            adj[b].Add(new KeyValuePair<string, double>(a, peso));
            return true;
        }

        public List<string> Nodos()
        {
            return new List<string>(adj.Keys);
        }

        public List<string> MostrarAdyacencias()
        {
            var res = new List<string>();
            var keys = new List<string>(adj.Keys);
            keys.Sort();
            foreach (var k in keys)
            {
                var parts = new List<string>();
                foreach (var p in adj[k])
                    parts.Add(p.Key + "(" + p.Value + ")");
                res.Add(k + " -> " + string.Join(", ", parts));
            }
            return res;
        }

        public bool EsConexo()
        {
            if (adj.Count == 0) return true;
            var visit = new HashSet<string>();
            var q = new Queue<string>();
            var start = new List<string>(adj.Keys)[0];
            q.Enqueue(start);
            visit.Add(start);
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

        public Tuple<double, List<string>> Dijkstra(string origen, string destino)
        {
            if (!adj.ContainsKey(origen) || !adj.ContainsKey(destino))
                return new Tuple<double, List<string>>(double.PositiveInfinity, new List<string>());

            var dist = new Dictionary<string, double>();
            var prev = new Dictionary<string, string>();
            var q = new List<string>();
            foreach (var n in adj.Keys)
            {
                dist[n] = double.PositiveInfinity;
                prev[n] = null;
                q.Add(n);
            }
            dist[origen] = 0.0;

            while (q.Count > 0)
            {
                q.Sort((x, y) => dist[x].CompareTo(dist[y]));
                var u = q[0];
                q.RemoveAt(0);
                if (double.IsInfinity(dist[u])) break;
                if (u == destino) break;
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

            if (double.IsInfinity(dist[destino])) return new Tuple<double, List<string>>(double.PositiveInfinity, new List<string>());

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
