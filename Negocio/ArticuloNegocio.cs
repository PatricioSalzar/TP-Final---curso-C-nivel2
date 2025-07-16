using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio_TP;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio from ARTICULOS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.CodArt = lector["Codigo"] != DBNull.Value ? lector["Codigo"].ToString() : null;
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Precio = (decimal)lector["Precio"];
                    if (!(lector["ImagenUrl"] is DBNull))
                    {
                        aux.Imagen = (string)lector["ImagenUrl"];
                    }
                    aux.Marca_articulo = new Marca();
                    aux.Marca_articulo.Id_marca = (int)lector["IdMarca"];
                    aux.Categoria_articulo = new Categoria();
                    aux.Categoria_articulo.Id_categoria = (int)lector["IdCategoria"];
                    ///FIJARME QUE EN LA CONSULRA NO ME ESTOY TRAYENDO EL NOMBRE DE LA MARCA NI DE LA CATEGORIA, CORREGIRLO.me tendria que traer la desrcripcion
                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, ImagenUrl, IdMarca, IdCategoria) " +
                                     "VALUES (@codigo, @nombre, @descripcion, @precio, @imagenUrl, @idMarca, @idCategoria)");
                datos.setearParametro("@codigo", nuevo.CodArt);
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@precio", nuevo.Precio);
                datos.setearParametro("@imagenUrl", nuevo.Imagen);
                datos.setearParametro("@idMarca", nuevo.Marca_articulo.Id_marca);
                datos.setearParametro("@idCategoria", nuevo.Categoria_articulo.Id_categoria);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, ImagenUrl = @imagenUrl, Precio = @precio, IdMarca = @idMarca, IdCategoria = @idCategoria where Id = @id");
                datos.setearParametro("@codigo", nuevo.CodArt);
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@imagenUrl", nuevo.Imagen);
                datos.setearParametro("@precio", nuevo.Precio);
                datos.setearParametro("@idMarca", nuevo.Marca_articulo.Id_marca);
                datos.setearParametro("@idCategoria", nuevo.Categoria_articulo.Id_categoria);
                datos.setearParametro("@id", nuevo.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id = @Id");
                datos.setearParametro("@Id",id);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
        }

        ///no hice la funcion de baja logica por que la clase articula no tiene un variable que represente su estado (alto-baja/true-false)
       
        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select Codigo, Nombre, A.Descripcion, ImagenUrl, M.Descripcion Marca_articulo, C.Descripcion Categoria_articulo, A.IdMarca, A.IdCategoria, A.Id, A.Precio AS Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id = A.IdCategoria and ";
                if(campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Menor a":
                            consulta += "Precio < " + filtro;
                            break;
                        case "Mayor a":
                            consulta += "Precio > " + filtro;
                            break;
                        default:
                            consulta += "Precio = " + filtro;
                            break;
                    }
                }
                else if(campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Nombre like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Nombre like '%" + filtro + "' ";
                            break;
                        default:
                            consulta += "Nombre like '%" + filtro + "%' ";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "A.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "A.Descripcion like '%" + filtro + "' ";
                            break;
                        default:
                            consulta += "A.Descripcion like '%" + filtro + "%' ";
                            break;
                    }
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.CodArt = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.Imagen = (string)datos.Lector["ImagenUrl"];

                    aux.Marca_articulo = new Marca();
                    aux.Marca_articulo.Id_marca = (int)datos.Lector["IdMarca"];
                    aux.Marca_articulo.Descripcion = (string)datos.Lector["Marca_articulo"];
                    aux.Categoria_articulo = new Categoria();
                    aux.Categoria_articulo.Id_categoria = (int)datos.Lector["IdCategoria"];
                    aux.Categoria_articulo.Descripcion = (string)datos.Lector["Categoria_articulo"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
