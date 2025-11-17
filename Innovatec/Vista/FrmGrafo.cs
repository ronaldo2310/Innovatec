using Innovatec.Estructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innovatec.Vista
{
    public partial class FrmGrafo : Form
    {
        private Grafo grafo = new Grafo();

        public FrmGrafo()
        {
            InitializeComponent();
        }

        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {
            if (grafo.AgregarNodo(txtNodo.Text))
            {
                RefrescarLista();
                txtNodo.Clear();
            }
            else MessageBox.Show("Nombre de nodo inválido o vacío.");
        }

        private void btnAgregarArista_Click(object sender, EventArgs e)
        {
            double peso;
            if (!double.TryParse(txtPeso.Text, out peso))
            {
                MessageBox.Show("Peso inválido.");
                return;
            }
            if (grafo.AgregarArista(txtA.Text, txtB.Text, peso))
            {
                RefrescarLista();
                txtA.Clear(); txtB.Clear(); txtPeso.Clear();
            }
            else MessageBox.Show("No se pudo agregar la arista (quizá ya existe).");
        }

        private void btnMostrarAdyacencias_Click(object sender, EventArgs e)
        {
            lstGrafo.Items.Clear();
            foreach (var s in grafo.MostrarAdyacencias()) lstGrafo.Items.Add(s);
        }

        private void btnConectividad_Click(object sender, EventArgs e)
        {
            MessageBox.Show(grafo.EsConexo() ? "El grafo es conexo." : "El grafo NO es conexo.");
        }

        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            var origen = txtOrigen.Text.Trim();
            var destino = txtDestino.Text.Trim();
            var resultado = grafo.Dijkstra(origen, destino);
            lstGrafo.Items.Clear();
            if (double.IsInfinity(resultado.Item1)) lstGrafo.Items.Add("No hay ruta entre los nodos.");
            else
            {
                lstGrafo.Items.Add("Distancia: " + resultado.Item1);
                lstGrafo.Items.Add("Camino: " + string.Join(" -> ", resultado.Item2));
            }
        }

        private void RefrescarLista()
        {
            lstGrafo.Items.Clear();
            lstGrafo.Items.Add("Nodos:");
            foreach (var n in grafo.Nodos()) lstGrafo.Items.Add("  " + n);
            lstGrafo.Items.Add("----------------------");
            foreach (var s in grafo.MostrarAdyacencias()) lstGrafo.Items.Add(s);
        }

    }
}
