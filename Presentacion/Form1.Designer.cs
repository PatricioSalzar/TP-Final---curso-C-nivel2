namespace Presentacion
{
    partial class ventan_tp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblfiltrado = new System.Windows.Forms.Label();
            this.txtbfiltro = new System.Windows.Forms.TextBox();
            this.lblcampo = new System.Windows.Forms.Label();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.lblcriterio = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtfiltroavanzado = new System.Windows.Forms.TextBox();
            this.cbocampo = new System.Windows.Forms.ComboBox();
            this.cbocriterio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.Location = new System.Drawing.Point(30, 69);
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.RowHeadersWidth = 51;
            this.dgvArticulo.RowTemplate.Height = 24;
            this.dgvArticulo.Size = new System.Drawing.Size(800, 301);
            this.dgvArticulo.TabIndex = 0;
            this.dgvArticulo.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(836, 69);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(340, 301);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulo.TabIndex = 1;
            this.pbArticulo.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 377);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(140, 376);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(252, 377);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblfiltrado
            // 
            this.lblfiltrado.AutoSize = true;
            this.lblfiltrado.Location = new System.Drawing.Point(27, 35);
            this.lblfiltrado.Name = "lblfiltrado";
            this.lblfiltrado.Size = new System.Drawing.Size(73, 16);
            this.lblfiltrado.TabIndex = 5;
            this.lblfiltrado.Text = "FILTRADO";
            this.lblfiltrado.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbfiltro
            // 
            this.txtbfiltro.Location = new System.Drawing.Point(107, 28);
            this.txtbfiltro.Name = "txtbfiltro";
            this.txtbfiltro.Size = new System.Drawing.Size(232, 22);
            this.txtbfiltro.TabIndex = 6;
            this.txtbfiltro.TextChanged += new System.EventHandler(this.txtbfiltro_TextChanged);
            // 
            // lblcampo
            // 
            this.lblcampo.AutoSize = true;
            this.lblcampo.Location = new System.Drawing.Point(30, 423);
            this.lblcampo.Name = "lblcampo";
            this.lblcampo.Size = new System.Drawing.Size(55, 16);
            this.lblcampo.TabIndex = 7;
            this.lblcampo.Text = "CAMPO";
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Location = new System.Drawing.Point(490, 423);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(54, 16);
            this.lblfiltro.TabIndex = 8;
            this.lblfiltro.Text = "FILTRO";
            // 
            // lblcriterio
            // 
            this.lblcriterio.AutoSize = true;
            this.lblcriterio.Location = new System.Drawing.Point(249, 423);
            this.lblcriterio.Name = "lblcriterio";
            this.lblcriterio.Size = new System.Drawing.Size(70, 16);
            this.lblcriterio.TabIndex = 9;
            this.lblcriterio.Text = "CRITERIO";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(674, 423);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(92, 23);
            this.btnbuscar.TabIndex = 10;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtfiltroavanzado
            // 
            this.txtfiltroavanzado.Location = new System.Drawing.Point(550, 417);
            this.txtfiltroavanzado.Name = "txtfiltroavanzado";
            this.txtfiltroavanzado.Size = new System.Drawing.Size(100, 22);
            this.txtfiltroavanzado.TabIndex = 11;
            // 
            // cbocampo
            // 
            this.cbocampo.FormattingEnabled = true;
            this.cbocampo.Location = new System.Drawing.Point(91, 418);
            this.cbocampo.Name = "cbocampo";
            this.cbocampo.Size = new System.Drawing.Size(121, 24);
            this.cbocampo.TabIndex = 12;
            this.cbocampo.SelectedIndexChanged += new System.EventHandler(this.cbocampo_SelectedIndexChanged);
            // 
            // cbocriterio
            // 
            this.cbocriterio.FormattingEnabled = true;
            this.cbocriterio.Location = new System.Drawing.Point(326, 417);
            this.cbocriterio.Name = "cbocriterio";
            this.cbocriterio.Size = new System.Drawing.Size(121, 24);
            this.cbocriterio.TabIndex = 13;
            // 
            // ventan_tp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 587);
            this.Controls.Add(this.cbocriterio);
            this.Controls.Add(this.cbocampo);
            this.Controls.Add(this.txtfiltroavanzado);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.lblcriterio);
            this.Controls.Add(this.lblfiltro);
            this.Controls.Add(this.lblcampo);
            this.Controls.Add(this.txtbfiltro);
            this.Controls.Add(this.lblfiltrado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.dgvArticulo);
            this.Name = "ventan_tp";
            this.Text = "ARTICULOS";
            this.Load += new System.EventHandler(this.ventan_tp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblfiltrado;
        private System.Windows.Forms.TextBox txtbfiltro;
        private System.Windows.Forms.Label lblcampo;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.Label lblcriterio;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtfiltroavanzado;
        private System.Windows.Forms.ComboBox cbocampo;
        private System.Windows.Forms.ComboBox cbocriterio;
    }
}

