namespace Innovatec.Vista
{
    partial class FrmGrafo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.btnAgregarNodo = new System.Windows.Forms.Button();
            this.lstGrafo = new System.Windows.Forms.ListBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnAgregarArista = new System.Windows.Forms.Button();
            this.btnMostrarAdyacencias = new System.Windows.Forms.Button();
            this.btnConectividad = new System.Windows.Forms.Button();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnDijkstra = new System.Windows.Forms.Button();
            this.lblNodo = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(480, 30);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(150, 20);
            this.txtNodo.TabIndex = 0;
            // 
            // btnAgregarNodo
            // 
            this.btnAgregarNodo.Location = new System.Drawing.Point(640, 30);
            this.btnAgregarNodo.Name = "btnAgregarNodo";
            this.btnAgregarNodo.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarNodo.TabIndex = 1;
            this.btnAgregarNodo.Text = "Agregar Nodo";
            this.btnAgregarNodo.UseVisualStyleBackColor = true;
            this.btnAgregarNodo.Click += new System.EventHandler(this.btnAgregarNodo_Click);
            // 
            // lstGrafo
            // 
            this.lstGrafo.FormattingEnabled = true;
            this.lstGrafo.Location = new System.Drawing.Point(20, 20);
            this.lstGrafo.Name = "lstGrafo";
            this.lstGrafo.Size = new System.Drawing.Size(440, 394);
            this.lstGrafo.TabIndex = 2;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(480, 80);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(70, 20);
            this.txtA.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(560, 80);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(70, 20);
            this.txtB.TabIndex = 4;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(640, 80);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 5;
            // 
            // btnAgregarArista
            // 
            this.btnAgregarArista.Location = new System.Drawing.Point(480, 110);
            this.btnAgregarArista.Name = "btnAgregarArista";
            this.btnAgregarArista.Size = new System.Drawing.Size(260, 25);
            this.btnAgregarArista.TabIndex = 6;
            this.btnAgregarArista.Text = "Agregar Arista (A - B - Peso)";
            this.btnAgregarArista.UseVisualStyleBackColor = true;
            this.btnAgregarArista.Click += new System.EventHandler(this.btnAgregarArista_Click);
            // 
            // btnMostrarAdyacencias
            // 
            this.btnMostrarAdyacencias.Location = new System.Drawing.Point(480, 160);
            this.btnMostrarAdyacencias.Name = "btnMostrarAdyacencias";
            this.btnMostrarAdyacencias.Size = new System.Drawing.Size(260, 25);
            this.btnMostrarAdyacencias.TabIndex = 7;
            this.btnMostrarAdyacencias.Text = "Mostrar Adyacencias";
            this.btnMostrarAdyacencias.UseVisualStyleBackColor = true;
            this.btnMostrarAdyacencias.Click += new System.EventHandler(this.btnMostrarAdyacencias_Click);
            // 
            // btnConectividad
            // 
            this.btnConectividad.Location = new System.Drawing.Point(480, 200);
            this.btnConectividad.Name = "btnConectividad";
            this.btnConectividad.Size = new System.Drawing.Size(260, 25);
            this.btnConectividad.TabIndex = 8;
            this.btnConectividad.Text = "Verificar Conectividad (BFS)";
            this.btnConectividad.UseVisualStyleBackColor = true;
            this.btnConectividad.Click += new System.EventHandler(this.btnConectividad_Click);
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(520, 260);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(100, 20);
            this.txtOrigen.TabIndex = 9;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(640, 260);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 20);
            this.txtDestino.TabIndex = 10;
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.Location = new System.Drawing.Point(480, 300);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(260, 25);
            this.btnDijkstra.TabIndex = 11;
            this.btnDijkstra.Text = "Calcular Ruta Más Corta (Dijkstra)";
            this.btnDijkstra.UseVisualStyleBackColor = true;
            this.btnDijkstra.Click += new System.EventHandler(this.btnDijkstra_Click);
            // 
            // lblNodo
            // 
            this.lblNodo.AutoSize = true;
            this.lblNodo.Location = new System.Drawing.Point(480, 12);
            this.lblNodo.Name = "lblNodo";
            this.lblNodo.Size = new System.Drawing.Size(33, 13);
            this.lblNodo.TabIndex = 13;
            this.lblNodo.Text = "Nodo";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(480, 62);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 14;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(560, 62);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 15;
            this.lblB.Text = "B";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(640, 62);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 16;
            this.lblPeso.Text = "Peso";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(480, 260);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.TabIndex = 17;
            this.lblOrigen.Text = "Origen";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(632, 242);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 18;
            this.lblDestino.Text = "Destino";
            // 
            // FrmGrafo
            // 
            this.ClientSize = new System.Drawing.Size(764, 440);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblNodo);
            this.Controls.Add(this.btnDijkstra);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.btnConectividad);
            this.Controls.Add(this.btnMostrarAdyacencias);
            this.Controls.Add(this.btnAgregarArista);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lstGrafo);
            this.Controls.Add(this.btnAgregarNodo);
            this.Controls.Add(this.txtNodo);
            this.Name = "FrmGrafo";
            this.Text = "Grafo - Rutas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Button btnAgregarNodo;
        private System.Windows.Forms.ListBox lstGrafo;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnAgregarArista;
        private System.Windows.Forms.Button btnMostrarAdyacencias;
        private System.Windows.Forms.Button btnConectividad;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnDijkstra;
        private System.Windows.Forms.Label lblNodo;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino;
    }
}