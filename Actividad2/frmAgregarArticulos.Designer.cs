namespace Actividad2P3
{
    partial class frmAgregarArticulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txbCodigo = new TextBox();
            txbNombre = new TextBox();
            txbDescripcion = new TextBox();
            txbImagen = new TextBox();
            txbPrecio = new TextBox();
            label1 = new Label();
            lblNombre = new Label();
            lnlDescripcion = new Label();
            lblMarca = new Label();
            lblCategoria = new Label();
            lblImagen = new Label();
            lblPrecio = new Label();
            cboMarca = new ComboBox();
            cboCategoria = new ComboBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            pbxNuevoArticulo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxNuevoArticulo).BeginInit();
            SuspendLayout();
            // 
            // txbCodigo
            // 
            txbCodigo.BackColor = Color.FromArgb(255, 192, 192);
            txbCodigo.BorderStyle = BorderStyle.None;
            txbCodigo.Location = new Point(129, 75);
            txbCodigo.Name = "txbCodigo";
            txbCodigo.Size = new Size(100, 16);
            txbCodigo.TabIndex = 0;
            // 
            // txbNombre
            // 
            txbNombre.BackColor = Color.FromArgb(255, 192, 192);
            txbNombre.BorderStyle = BorderStyle.None;
            txbNombre.Location = new Point(129, 97);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(100, 16);
            txbNombre.TabIndex = 1;
            // 
            // txbDescripcion
            // 
            txbDescripcion.BackColor = Color.FromArgb(255, 192, 192);
            txbDescripcion.BorderStyle = BorderStyle.None;
            txbDescripcion.Location = new Point(129, 119);
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.Size = new Size(100, 16);
            txbDescripcion.TabIndex = 2;
            // 
            // txbImagen
            // 
            txbImagen.BackColor = Color.FromArgb(255, 192, 192);
            txbImagen.BorderStyle = BorderStyle.None;
            txbImagen.Location = new Point(129, 201);
            txbImagen.Name = "txbImagen";
            txbImagen.Size = new Size(100, 16);
            txbImagen.TabIndex = 5;
            txbImagen.Leave += txbImagen_Leave;
            // 
            // txbPrecio
            // 
            txbPrecio.BackColor = Color.FromArgb(255, 192, 192);
            txbPrecio.BorderStyle = BorderStyle.None;
            txbPrecio.Location = new Point(129, 223);
            txbPrecio.Name = "txbPrecio";
            txbPrecio.Size = new Size(100, 16);
            txbPrecio.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 76);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 7;
            label1.Text = "Codigo de Articulo:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(69, 98);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre:";
            // 
            // lnlDescripcion
            // 
            lnlDescripcion.AutoSize = true;
            lnlDescripcion.Location = new Point(51, 120);
            lnlDescripcion.Name = "lnlDescripcion";
            lnlDescripcion.Size = new Size(72, 15);
            lnlDescripcion.TabIndex = 9;
            lnlDescripcion.Text = "Descripcion:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(80, 151);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(43, 15);
            lblMarca.TabIndex = 10;
            lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(62, 180);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 11;
            lblCategoria.Text = "Categoria:";
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.Location = new Point(48, 202);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(74, 15);
            lblImagen.TabIndex = 12;
            lblImagen.Text = "URL Imagen:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(80, 224);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 13;
            lblPrecio.Text = "Precio:";
            // 
            // cboMarca
            // 
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(129, 143);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(121, 23);
            cboMarca.TabIndex = 3;
            cboMarca.SelectedIndexChanged += cboMarca_SelectedIndexChanged;
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(129, 172);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(121, 23);
            cboCategoria.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(48, 310);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(175, 310);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pbxNuevoArticulo
            // 
            pbxNuevoArticulo.Location = new Point(292, 75);
            pbxNuevoArticulo.Name = "pbxNuevoArticulo";
            pbxNuevoArticulo.Size = new Size(253, 211);
            pbxNuevoArticulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxNuevoArticulo.TabIndex = 18;
            pbxNuevoArticulo.TabStop = false;
            // 
            // frmAgregarArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(581, 366);
            Controls.Add(pbxNuevoArticulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(cboCategoria);
            Controls.Add(cboMarca);
            Controls.Add(lblPrecio);
            Controls.Add(lblImagen);
            Controls.Add(lblCategoria);
            Controls.Add(lblMarca);
            Controls.Add(lnlDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Controls.Add(txbPrecio);
            Controls.Add(txbImagen);
            Controls.Add(txbDescripcion);
            Controls.Add(txbNombre);
            Controls.Add(txbCodigo);
            MaximumSize = new Size(597, 405);
            MinimumSize = new Size(597, 405);
            Name = "frmAgregarArticulos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Articulo";
            Load += frmAgregarArticulos_Load;
            ((System.ComponentModel.ISupportInitialize)pbxNuevoArticulo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbCodigo;
        private TextBox txbNombre;
        private TextBox txbDescripcion;
        private TextBox txbImagen;
        private TextBox txbPrecio;
        private Label label1;
        private Label lblNombre;
        private Label lnlDescripcion;
        private Label lblMarca;
        private Label lblCategoria;
        private Label lblImagen;
        private Label lblPrecio;
        private ComboBox cboMarca;
        private ComboBox cboCategoria;
        private Button btnAgregar;
        private Button btnCancelar;
        private PictureBox pbxNuevoArticulo;
    }
}