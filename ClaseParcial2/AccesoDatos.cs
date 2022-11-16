using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClaseParcial2
{
    public class AccesoDatos
    {
        #region Atributos

        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        #endregion

        #region Constructores

        static AccesoDatos()
        {
            AccesoDatos.cadena_conexion = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dtbase_generala;Data Source=DESKTOP-45ITKTF";
        }

        public AccesoDatos()
        {
            // CREO UN OBJETO SQLCONECTION
            this.conexion = new SqlConnection(AccesoDatos.cadena_conexion);
        }

        #endregion

        #region Métodos

        #region Probar conexión

        public bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                this.conexion.Open();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Select

        public List<JugadorPersona> ObtenerListaDato()
        {
            List<JugadorPersona> lista = new List<JugadorPersona>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM dbo.tabla_jugadores";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    JugadorPersona item = new JugadorPersona();

                    // ACCEDO POR NOMBRE, POR INDICE O POR GETTER (SEGUN TIPO DE DATO)
                    item.id = (int)lector["id"];
                    item.nombre = lector["nombre"].ToString();
                    item.apellido = lector["apellido"].ToString();
                    item.usuario = lector["usuario"].ToString();
                    item.password = lector["password"].ToString();
                    item.partidasPerdidas = int.Parse(lector["partidasPerdidas"].ToString());
                    item.partidasGanadas = int.Parse(lector["partidasGanadas"].ToString());
                    item.partidasJugadas = int.Parse(lector["partidasJugadas"].ToString());

                    lista.Add(item);
                }

                lector.Close();

            }
            catch(Exception)
            {
                return null;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lista;
        }

        #endregion

        #region Insert

        public bool AgregarDato(JugadorPersona param)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO dbo.tabla_jugadores (nombre, apellido, usuario, password, partidasPerdidas, partidasGanadas, partidasJugadas) VALUES(";
                sql = sql + "'" + param.nombre + "','" + param.apellido + "','" + param.usuario + "','" + param.password + "'," + 
                param.partidasPerdidas.ToString() + "," + param.partidasGanadas.ToString() + "," + param.partidasJugadas.ToString() + ")";

                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception )
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Update

        public bool ModificarDato(JugadorPersona param)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", param.id);
                this.comando.Parameters.AddWithValue("@nombre", param.nombre);
                this.comando.Parameters.AddWithValue("@apellido", param.apellido);
                this.comando.Parameters.AddWithValue("@usuario", param.usuario);
                this.comando.Parameters.AddWithValue("@password", param.password);
                this.comando.Parameters.AddWithValue("@partidasPerdidas", param.partidasPerdidas);
                this.comando.Parameters.AddWithValue("@partidasGanadas", param.partidasGanadas);
                this.comando.Parameters.AddWithValue("@partidasJugadas", param.partidasJugadas);

                string sql = "UPDATE dbo.tabla_jugadores ";
                sql += "SET nombre = @nombre, apellido = @apellido, usuario = @usuario, password = @password, partidasPerdidas = @partidasGanadas, partidasJugadas = @partidasJugadas ";
                sql += "WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return rta;
        }

        #endregion

        #region Delete

        public bool EliminarDato(int id)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM dbo.tabla_jugadores ";
                sql += "WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #endregion
    }
}
