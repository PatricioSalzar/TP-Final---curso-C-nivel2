namespace Presentacion
{
    partial class ventanaAlta
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
            this.pbarticulo = new System.Windows.Forms.PictureBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txturlimagen = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblurlimagen = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lblmarca = new System.Windows.Forms.Label();
            this.cbocategoria = new System.Windows.Forms.ComboBox();
            this.cbomarca = new System.Windows.Forms.ComboBox();
            this.btbagregarimagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbarticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbarticulo
            // 
            this.pbarticulo.Location = new System.Drawing.Point(278, 30);
            this.pbarticulo.Name = "pbarticulo";
            this.pbarticulo.Size = new System.Drawing.Size(294, 289);
            this.pbarticulo.TabIndex = 0;
            this.pbarticulo.TabStop = false;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(172, 30);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 22);
            this.txtcodigo.TabIndex = 1;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(172, 59);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 22);
            this.txtnombre.TabIndex = 2;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(172, 88);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(100, 22);
            this.txtdescripcion.TabIndex = 3;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(171, 117);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 22);
            this.txtprecio.TabIndex = 4;
            // 
            // txturlimagen
            // 
            this.txturlimagen.Location = new System.Drawing.Point(133, 150);
            this.txturlimagen.Name = "txturlimagen";
            this.txturlimagen.Size = new System.Drawing.Size(100, 22);
            this.txturlimagen.TabIndex = 5;
            this.txturlimagen.Leave += new System.EventHandler(this.txturlimagen_Leave);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(278, 326);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 8;
            this.btnaceptar.Text = "aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(360, 326);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(122, 33);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(49, 16);
            this.lblcodigo.TabIndex = 10;
            this.lblcodigo.Text = "codigo";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(113, 62);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(53, 16);
            this.lblnombre.TabIndex = 11;
            this.lblnombre.Text = "nombre";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(89, 88);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(77, 16);
            this.lbldescripcion.TabIndex = 12;
            this.lbldescripcion.Text = "descripcion";
            this.lbldescripcion.Click += new System.EventHandler(this.lbldescripcion_Click);
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(120, 120);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(45, 16);
            this.lblprecio.TabIndex = 13;
            this.lblprecio.Text = "precio";
            this.lblprecio.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblurlimagen
            // 
            this.lblurlimagen.AutoSize = true;
            this.lblurlimagen.Location = new System.Drawing.Point(61, 152);
            this.lblurlimagen.Name = "lblurlimagen";
            this.lblurlimagen.Size = new System.Drawing.Size(66, 16);
            this.lblurlimagen.TabIndex = 14;
            this.lblurlimagen.Text = "urlImagen";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(79, 181);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(64, 16);
            this.lblcategoria.TabIndex = 15;
            this.lblcategoria.Text = "categoria";
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(97, 209);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(45, 16);
            this.lblmarca.TabIndex = 16;
            this.lblmarca.Text = "marca";
            // 
            // cbocategoria
            // 
            this.cbocategoria.FormattingEnabled = true;
            this.cbocategoria.Location = new System.Drawing.Point(149, 178);
            this.cbocategoria.Name = "cbocategoria";
            this.cbocategoria.Size = new System.Drawing.Size(121, 24);
            this.cbocategoria.TabIndex = 17;
            // 
            // cbomarca
            // 
            this.cbomarca.FormattingEnabled = true;
            this.cbomarca.Location = new System.Drawing.Point(148, 209);
            this.cbomarca.Name = "cbomarca";
            this.cbomarca.Size = new System.Drawing.Size(121, 24);
            this.cbomarca.TabIndex = 18;
            // 
            // btbagregarimagen
            // 
            this.btbagregarimagen.Location = new System.Drawing.Point(239, 149);
            this.btbagregarimagen.Name = "btbagregarimagen";
            this.btbagregarimagen.Size = new System.Drawing.Size(33, 23);
            this.btbagregarimagen.TabIndex = 19;
            this.btbagregarimagen.Text = "+";
            this.btbagregarimagen.UseVisualStyleBackColor = true;
            this.btbagregarimagen.Click += new System.EventHandler(this.btbagregarimagen_Click);
            // 
            // ventanaAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbagregarimagen);
            this.Controls.Add(this.cbomarca);
            this.Controls.Add(this.cbocategoria);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.lblurlimagen);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txturlimagen);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.pbarticulo);
            this.Name = "ventanaAlta";
            this.Text = "ventanaAlta";
            this.Load += new System.EventHandler(this.ventanaAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbarticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbarticulo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txturlimagen;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblurlimagen;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.ComboBox cbocategoria;
        private System.Windows.Forms.ComboBox cbomarca;
        private System.Windows.Forms.Button btbagregarimagen;
    }
}