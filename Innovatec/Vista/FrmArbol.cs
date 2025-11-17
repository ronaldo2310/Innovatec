using System;
using System.Windows.Forms;
using Innovatec.Estructura;

namespace Innovatec.Vista
{
    public partial class FrmArbol : Form
    {
        private ArbolGeneral arbol = new ArbolGeneral();

        public FrmArbol()
        {
            InitializeComponent();

            arbol.CrearRaiz(1, "Innovatec");
            MostrarArbol();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (lstArbol.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un nodo padre en la lista.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreNuevo.Text))
            {
                MessageBox.Show("Ingrese el nombre del nuevo nodo.");
                return;
            }

            string linea = lstArbol.SelectedItem.ToString();
            int padreId = int.Parse(linea.Split(']')[0].Replace("[", ""));

            int nuevoId = arbol.ContarNodos() + 1;

            if (arbol.Insertar(padreId, nuevoId, txtNombreNuevo.Text.Trim()))
            {
                MostrarArbol();
                txtNombreNuevo.Clear();
            }
            else
                MessageBox.Show("No se pudo insertar.");
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Nodos: {arbol.ContarNodos()}");
        }

        private void btnNiveles_Click(object sender, EventArgs e)
        {
            lstArbol.Items.Clear();
            foreach (var x in arbol.ObtenerNiveles())
                lstArbol.Items.Add($"ID {x.Key} -> Nivel {x.Value}");
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            MostrarArbol();
        }

        private void MostrarArbol()
        {
            lstArbol.Items.Clear();
            if (arbol.Raiz == null)
            {
                lstArbol.Items.Add("Árbol vacío");
                return;
            }
            arbol.RecorrerPreorden(arbol.Raiz, lstArbol);
        }
    }
}
