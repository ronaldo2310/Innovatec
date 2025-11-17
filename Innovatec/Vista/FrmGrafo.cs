using Innovatec.Estructura;
using System;
using System.Windows.Forms;

namespace Innovatec.Vista
{
    /// <summary>
    /// Formulario encargado de administrar, visualizar y operar sobre un grafo.
    /// Permite agregar nodos, agregar aristas, mostrar adyacencias,
    /// verificar conectividad y ejecutar Dijkstra.
    /// </summary>
    public partial class FrmGrafo : Form
    {
        /// <summary>
        /// Instancia principal del grafo utilizado por el formulario.
        /// </summary>
        private Grafo grafo = new Grafo();

        /// <summary>
        /// Constructor del formulario. Inicializa los componentes gráficos.
        /// </summary>
        public FrmGrafo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que permite agregar un nodo al grafo usando el nombre ingresado.
        /// </summary>
        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {
            // Intentar agregar el nodo. Devuelve false si ya existe o es inválido.
            if (grafo.AgregarNodo(txtNodo.Text))
            {
                RefrescarLista();
                txtNodo.Clear();
            }
            else
                MessageBox.Show("Nombre de nodo inválido o vacío.");
        }

        /// <summary>
        /// Evento que crea una arista entre dos nodos con un peso asociado.
        /// </summary>
        private void btnAgregarArista_Click(object sender, EventArgs e)
        {
            double peso;

            // Verificar que el peso sea un número válido.
            if (!double.TryParse(txtPeso.Text, out peso))
            {
                MessageBox.Show("Peso inválido.");
                return;
            }

            // Intentar agregar la arista al grafo.
            if (grafo.AgregarArista(txtA.Text, txtB.Text, peso))
            {
                RefrescarLista();
                txtA.Clear();
                txtB.Clear();
                txtPeso.Clear();
            }
            else
                MessageBox.Show("No se pudo agregar la arista (quizá ya existe).");
        }

        /// <summary>
        /// Muestra en la lista todas las adyacencias del grafo.
        /// </summary>
        private void btnMostrarAdyacencias_Click(object sender, EventArgs e)
        {
            lstGrafo.Items.Clear();

            // Recorrer cada línea generada por el método MostrarAdyacencias.
            foreach (var s in grafo.MostrarAdyacencias())
                lstGrafo.Items.Add(s);
        }

        /// <summary>
        /// Verifica si el grafo es conexo y lo muestra mediante un mensaje.
        /// </summary>
        private void btnConectividad_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                grafo.EsConexo() ? "El grafo es conexo." : "El grafo NO es conexo.");
        }

        /// <summary>
        /// Ejecuta el algoritmo de Dijkstra para determinar la ruta más corta
        /// entre un nodo origen y un nodo destino.
        /// </summary>
        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            var origen = txtOrigen.Text.Trim();
            var destino = txtDestino.Text.Trim();

            // Resultado.Item1 = distancia mínima
            // Resultado.Item2 = lista de nodos del camino
            var resultado = grafo.Dijkstra(origen, destino);

            lstGrafo.Items.Clear();

            // Si la distancia es Infinito, no existe ruta.
            if (double.IsInfinity(resultado.Item1))
            {
                lstGrafo.Items.Add("No hay ruta entre los nodos.");
            }
            else
            {
                lstGrafo.Items.Add("Distancia: " + resultado.Item1);
                lstGrafo.Items.Add("Camino: " + string.Join(" -> ", resultado.Item2));
            }
        }

        /// <summary>
        /// Refresca la lista mostrando todos los nodos y sus adyacencias.
        /// </summary>
        private void RefrescarLista()
        {
            lstGrafo.Items.Clear();

            lstGrafo.Items.Add("Nodos:");
            foreach (var n in grafo.Nodos())
                lstGrafo.Items.Add("  " + n);

            lstGrafo.Items.Add("----------------------");

            // Mostrar lista de adyacencias
            foreach (var s in grafo.MostrarAdyacencias())
                lstGrafo.Items.Add(s);
        }
    }
}
