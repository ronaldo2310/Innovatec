using System;
using System.Windows.Forms;
using Innovatec.Estructura;

namespace Innovatec.Vista
{
    /// <summary>
    /// Formulario encargado de administrar y visualizar un árbol general.
    /// </summary>
    public partial class FrmArbol : Form
    {
        /// <summary>
        /// Instancia principal del árbol usado en el formulario.
        /// </summary>
        private ArbolGeneral arbol = new ArbolGeneral();

        /// <summary>
        /// Constructor del formulario. Inicializa la interfaz
        /// y crea la raíz del árbol por defecto.
        /// </summary>
        public FrmArbol()
        {
            InitializeComponent();

            // Crear la raíz del árbol con ID = 1 y nombre "Innovatec".
            arbol.CrearRaiz(1, "Innovatec");

            // Mostrar el árbol en la lista.
            MostrarArbol();
        }

        /// <summary>
        /// Evento para insertar un nuevo nodo como hijo del nodo seleccionado.
        /// </summary>
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un nodo padre.
            if (lstArbol.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un nodo padre en la lista.");
                return;
            }

            // Validar que se haya ingresado un nombre para el nuevo nodo.
            if (string.IsNullOrWhiteSpace(txtNombreNuevo.Text))
            {
                MessageBox.Show("Ingrese el nombre del nuevo nodo.");
                return;
            }

            // Obtener el ID del nodo seleccionado a partir del texto mostrado.
            string linea = lstArbol.SelectedItem.ToString();
            int padreId = int.Parse(linea.Split(']')[0].Replace("[", ""));

            // Generar el nuevo ID basado en la cantidad actual de nodos.
            int nuevoId = arbol.ContarNodos() + 1;

            // Intentar insertar el nodo en el árbol.
            if (arbol.Insertar(padreId, nuevoId, txtNombreNuevo.Text.Trim()))
            {
                MostrarArbol();
                txtNombreNuevo.Clear();
            }
            else
            {
                MessageBox.Show("No se pudo insertar.");
            }
        }

        /// <summary>
        /// Muestra la cantidad total de nodos del árbol.
        /// </summary>
        private void btnContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Nodos: {arbol.ContarNodos()}");
        }

        /// <summary>
        /// Obtiene y muestra el nivel de cada nodo dentro del árbol.
        /// </summary>
        private void btnNiveles_Click(object sender, EventArgs e)
        {
            lstArbol.Items.Clear();

            // Recorre la lista de niveles (ID -> nivel).
            foreach (var x in arbol.ObtenerNiveles())
                lstArbol.Items.Add($"ID {x.Key} -> Nivel {x.Value}");
        }

        /// <summary>
        /// Refresca el árbol usando un recorrido preorden.
        /// </summary>
        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            MostrarArbol();
        }

        /// <summary>
        /// Muestra el árbol completo en la lista, en recorrido preorden.
        /// </summary>
        private void MostrarArbol()
        {
            lstArbol.Items.Clear();

            // Validar si el árbol tiene raíz.
            if (arbol.Raiz == null)
            {
                lstArbol.Items.Add("Árbol vacío");
                return;
            }

            // Llamar al método RecorrerPreorden del árbol.
            arbol.RecorrerPreorden(arbol.Raiz, lstArbol);
        }
    }
}
