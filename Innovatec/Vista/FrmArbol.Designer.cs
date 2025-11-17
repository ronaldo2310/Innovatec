namespace Innovatec.Vista
{
    partial class FrmArbol
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.btnNiveles = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lstArbol = new System.Windows.Forms.ListBox();
            this.lblInsertar = new System.Windows.Forms.Label();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Location = new System.Drawing.Point(50, 78);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(120, 20);
            this.txtNombreNuevo.TabIndex = 5;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(188, 78);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(90, 23);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(50, 137);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(90, 23);
            this.btnContar.TabIndex = 9;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // btnNiveles
            // 
            this.btnNiveles.Location = new System.Drawing.Point(188, 137);
            this.btnNiveles.Name = "btnNiveles";
            this.btnNiveles.Size = new System.Drawing.Size(120, 23);
            this.btnNiveles.TabIndex = 10;
            this.btnNiveles.Text = "Mostrar niveles";
            this.btnNiveles.UseVisualStyleBackColor = true;
            this.btnNiveles.Click += new System.EventHandler(this.btnNiveles_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(347, 137);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(100, 23);
            this.btnRecorrer.TabIndex = 11;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lstArbol
            // 
            this.lstArbol.FormattingEnabled = true;
            this.lstArbol.Location = new System.Drawing.Point(50, 230);
            this.lstArbol.Name = "lstArbol";
            this.lstArbol.Size = new System.Drawing.Size(660, 199);
            this.lstArbol.TabIndex = 12;
            // 
            // lblInsertar
            // 
            this.lblInsertar.AutoSize = true;
            this.lblInsertar.Location = new System.Drawing.Point(47, 24);
            this.lblInsertar.Name = "lblInsertar";
            this.lblInsertar.Size = new System.Drawing.Size(69, 13);
            this.lblInsertar.TabIndex = 16;
            this.lblInsertar.Text = "Insertar nodo";
            // 
            // lblNombreNuevo
            // 
            this.lblNombreNuevo.AutoSize = true;
            this.lblNombreNuevo.Location = new System.Drawing.Point(47, 53);
            this.lblNombreNuevo.Name = "lblNombreNuevo";
            this.lblNombreNuevo.Size = new System.Drawing.Size(44, 13);
            this.lblNombreNuevo.TabIndex = 19;
            this.lblNombreNuevo.Text = "Nombre";
            // 
            // FrmArbol
            // 
            this.ClientSize = new System.Drawing.Size(760, 460);
            this.Controls.Add(this.lblNombreNuevo);
            this.Controls.Add(this.lblInsertar);
            this.Controls.Add(this.lstArbol);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnNiveles);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtNombreNuevo);
            this.Name = "FrmArbol";
            this.Text = "Árbol General - Gestión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnNiveles;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.ListBox lstArbol;
        private System.Windows.Forms.Label lblInsertar;
        private System.Windows.Forms.Label lblNombreNuevo;
    }
}