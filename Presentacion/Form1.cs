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
using Dominio_TP;
using Negocio;

namespace Presentacion
{
    public partial class ventan_tp : Form
    {
        private List<Articulo> LIstaArticulo;
        public ventan_tp()
        {
            InitializeComponent();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                LIstaArticulo = negocio.listar();

                dgvArticulo.DataSource = LIstaArticulo;
                ocultarColumnas();
                cargarImagen(LIstaArticulo[0].Imagen);
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulo.Columns["Imagen"].Visible = false;
            dgvArticulo.Columns["Id"].Visible = false;
            //dgvArticulo.Columns["Marca_articulo"].Visible = false;
            //dgvArticulo.Columns["Categoria_articulo"].Visible = false;
        }

        private void cargarImagen(string url)
        {
            try
            {
                // Libera imagen previa si existe
                if (pbArticulo.Image != null)
                {
                    pbArticulo.Image.Dispose();
                    pbArticulo.Image = null;
                }

                if (!string.IsNullOrWhiteSpace(url))
                {
                    // Validación simple por URL web
                    if (url.StartsWith("http", StringComparison.OrdinalIgnoreCase))
                    {
                        using (var client = new System.Net.WebClient())
                        {
                            byte[] imageData = client.DownloadData(url);
                            using (var ms = new MemoryStream(imageData))
                            {
                                pbArticulo.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    else if (File.Exists(url)) // Si es archivo local
                    {
                        pbArticulo.Image = Image.FromFile(url);
                    }
                    else
                    {
                        // Carga imagen por defecto si URL inválida
                        pbArticulo.Load("https://winguweb.org/wp-content/uploads/2022/09/placeholder.png");
                    }
                }
                else
                {
                    pbArticulo.Load("https://winguweb.org/wp-content/uploads/2022/09/placeholder.png");
                }
            }
            catch
            {
                pbArticulo.Load("https://winguweb.org/wp-content/uploads/2022/09/placeholder.png");
            }
        }

        private List<Marca> listaMarcas;
        private List<Categoria> listaCategortia;

        private void ventan_tp_Load(object sender, EventArgs e)
        {
            cargar();
            cbocampo.Items.Add("Nombre");
            cbocampo.Items.Add("Descripcion");
            cbocampo.Items.Add("Precio");
            cbocampo.Items.Add("Marca");
            cbocampo.Items.Add("Categoria");

            MarcaNegocio marcanegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            listaMarcas = marcanegocio.listar();
            listaCategortia = categoriaNegocio.listarCategoria();

        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulo.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ventanaAlta alta = new ventanaAlta();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            ventanaAlta modificar = new ventanaAlta(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo eliminado;
            try
            {
                DialogResult respuestas = MessageBox.Show("¿Estas seguro que queres eliminar este articulo?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuestas == DialogResult.Yes)
                {
                    eliminado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                    negocio.eliminar(eliminado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbfiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtbfiltro.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = LIstaArticulo.FindAll(x =>
                    (x.Nombre?.ToUpper().Contains(filtro.ToUpper()) ?? false) ||
                    (x.Marca_articulo?.Descripcion?.ToUpper().Contains(filtro.ToUpper()) ?? false) ||
                    (x.Categoria_articulo?.Descripcion?.ToUpper().Contains(filtro.ToUpper()) ?? false)
                );
            }
            else
            {
                listaFiltrada = LIstaArticulo;
            }

            dgvArticulo.DataSource = null;
            dgvArticulo.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cbocampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbocampo.SelectedItem.ToString();
            cbocriterio.DataSource = null;
            cbocriterio.Items.Clear();

            if (opcion == "Precio")
            {
                cbocriterio.Items.Add("Mayor a");
                cbocriterio.Items.Add("Menor a");
                cbocriterio.Items.Add("Igual a");
            }
            else if(opcion == "Categoria")
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                cbocriterio.DataSource = categoriaNegocio.listarCategoria(); // asumimos que retorna List<Categoria>
                cbocriterio.DisplayMember = "Descripcion";
                cbocriterio.ValueMember = "Id_categoria";
                txtfiltroavanzado.Visible = false;
                cbocriterio.Visible = true;
            }
            else if(opcion == "Marca")
            {
                MarcaNegocio marcanegocio = new MarcaNegocio();
                cbocriterio.DataSource = marcanegocio.listar(); // asumimos que retorna List<Categoria>
                cbocriterio.DisplayMember = "Descripcion";
                cbocriterio.ValueMember = "Id_marca";
                txtfiltroavanzado.Visible = false;
                cbocriterio.Visible = true;
            }
            else
            {
                cbocriterio.Items.Add("Comienza con");
                cbocriterio.Items.Add("Termina con");
                cbocriterio.Items.Add("Contiene");
            }
        }

        private bool validacionfiltro()
        {
            if (cbocampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione un campo para filtrar.");
                return true;
            }

            if (cbocriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione un criterio para filtrar.");
                return true;
            }

            if (cbocampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtfiltroavanzado.Text))
                {
                    MessageBox.Show("Debe ingresar un valor para filtrar por precio.");
                    return true;
                }

                if (!decimal.TryParse(txtfiltroavanzado.Text, out _))
                {
                    MessageBox.Show("Solo se aceptan números para filtrar por precio.");
                    return true;
                }
            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validacionfiltro())
                    return;

                string campo = cbocampo.SelectedItem.ToString();
                string criterio = cbocriterio.SelectedItem.ToString();
                string filtro = txtfiltroavanzado.Text;

                if (campo == "Marca" || campo == "Categoria")
                {
                    criterio = ""; // no se usa
                    filtro = cbocriterio.SelectedValue.ToString(); // importante

                    if (string.IsNullOrEmpty(filtro))
                    {
                        MessageBox.Show("Debe seleccionar una marca o categoría válida.");
                        return;
                    }

                    dgvArticulo.DataSource = negocio.FiltrarMarcaCategoria(campo, filtro);
                }
                else
                {
                    if (string.IsNullOrEmpty(txtfiltroavanzado.Text) || cbocriterio.SelectedItem == null)
                    {
                        MessageBox.Show("Debe ingresar un filtro válido.");
                        return;
                    }

                    criterio = cbocriterio.SelectedItem.ToString();
                    filtro = txtfiltroavanzado.Text;
                    dgvArticulo.DataSource = negocio.filtrar(campo, criterio, filtro);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
