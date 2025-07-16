using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio_TP;
using Negocio;
using System.Configuration;
using System.Configuration.Internal;
using System.IO;

namespace Presentacion
{
    public partial class ventanaAlta : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;  
        public ventanaAlta()
        {
            InitializeComponent();
        }
        public ventanaAlta(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "MODIFICAR ARTICULO";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbldescripcion_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                    if(articulo == null)
                        articulo = new Articulo();
                    articulo.CodArt = txtcodigo.Text;
                    articulo.Nombre = txtnombre.Text;
                    articulo.Descripcion = txtdescripcion.Text;
                    articulo.Precio = decimal.Parse(txtprecio.Text);
                    articulo.Imagen = txturlimagen.Text;
                    articulo.Categoria_articulo = (Categoria)cbocategoria.SelectedItem;
                    articulo.Marca_articulo = (Marca)cbomarca.SelectedItem;
                    if (archivo != null && !txturlimagen.Text.ToUpper().Contains("HTTP"))
                    {
                        string carpetaDestino = ConfigurationManager.AppSettings["images-folder"];
                        Directory.CreateDirectory(carpetaDestino); // Asegura que exista
                        string nombreArchivo = Path.GetFileName(archivo.FileName);
                        string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);

                        if (!File.Exists(rutaDestino))
                            File.Copy(archivo.FileName, rutaDestino);

                        articulo.Imagen = nombreArchivo; // Guardar solo el nombre
                    }
                    if (articulo.Id != 0)
                    {
                        negocio.modificar(articulo);
                        MessageBox.Show("MODIFICADO EXITOSAMENTE");
                    }
                    else
                    {
                        negocio.agregar(articulo);
                        MessageBox.Show("AGREGADO EXITOSAMENTE");
                    }
                    if(archivo != null && !(txturlimagen.Text.ToUpper().Contains("HTTP")))
                    {
                        File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.FileName);
                    }
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ventanaAlta_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcagnegocio = new MarcaNegocio();
            try
            {
                cbocategoria.DataSource = categoriaNegocio.listarCategoria();
                cbocategoria.ValueMember = "Id_categoria";
                cbocategoria.DisplayMember = "Descripcion";
                cbomarca.DataSource = marcagnegocio.listar();
                cbomarca.ValueMember = "Id_marca";
                cbomarca.DisplayMember = "Descripcion";
                if (articulo != null)
                {
                    txtcodigo.Text = articulo.CodArt.ToString();
                    txtnombre.Text = articulo.Nombre;
                    txtdescripcion.Text = articulo.Descripcion;
                    txtprecio.Text = articulo.Precio.ToString();
                    txturlimagen.Text = articulo.Imagen;
                    cargarimagen(articulo.Imagen);
                    cbocategoria.SelectedValue = articulo.Categoria_articulo.Id_categoria;
                    cbomarca.SelectedValue = articulo.Marca_articulo.Id_marca;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarimagen(string imagen)
        {
            try
            {
                if (!imagen.ToUpper().Contains("HTTP"))
                {
                    string ruta = Path.Combine(ConfigurationManager.AppSettings["images-folder"], imagen);
                    pbarticulo.Load(ruta);
                }
                else
                {
                    pbarticulo.Load(imagen);
                }
            }
            catch
            {
                pbarticulo.Load("https://winguweb.org/wp-content/uploads/2022/09/placeholder.png");
            }
        }

        private void txturlimagen_Leave(object sender, EventArgs e)
        {
            cargarimagen(txturlimagen.Text);
        }

        private void btbagregarimagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txturlimagen.Text = archivo.FileName;
                cargarimagen(archivo.FileName);
            }
        }
    }
}
