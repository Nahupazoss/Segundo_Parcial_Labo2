using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseParcial2;

namespace ClaseParcial2
{
    public class AccesoDatosPartida
    {
        #region Atributos

        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        #endregion

        #region Constructores

        static AccesoDatosPartida()
        {
            AccesoDatosPartida.cadena_conexion = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=dtbase_generala;Data Source=DESKTOP-45ITKTF";
        }

        public AccesoDatosPartida()
        {
            // CREO UN OBJETO SQLCONECTION
            this.conexion = new SqlConnection(AccesoDatosPartida.cadena_conexion);
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

        public List<PartidaTerminada> ObtenerListaDato()
        {
            List<PartidaTerminada> lista = new List<PartidaTerminada>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM dbo.historialPartidas";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    PartidaTerminada item = new PartidaTerminada();

                    // ACCEDO POR NOMBRE, POR INDICE O POR GETTER (SEGUN TIPO DE DATO)
                    item.Id = lector.GetInt32(0);
                    item.Jugador1 = lector["jugador1"].ToString();
                    item.Jugador2 = lector["jugador2"].ToString();
                    item.Puntaje1 =  int.Parse(lector["puntaje1"].ToString());
                    item.Puntaje2 =  int.Parse(lector["puntaje2"].ToString());
                    item.Ganador = lector["ganador"].ToString();

                    lista.Add(item);
                }

                lector.Close();

            }
            catch (Exception)
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


        public List<PartidaTerminada> ObtenerPartidasPorJugador(string nombreJugador)
        {
            List<PartidaTerminada> lista = new List<PartidaTerminada>();
            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM dbo.historialPartidas WHERE jugador1 = @nombreJugador";
                this.comando.Connection = this.conexion;

                this.comando.Parameters.AddWithValue("@nombreJugador", nombreJugador);

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    PartidaTerminada item = new PartidaTerminada();

                    // ACCEDO POR NOMBRE, POR INDICE O POR GETTER (SEGUN TIPO DE DATO)
                    item.Id = lector.GetInt32(0);
                    item.Jugador1 = lector["jugador1"].ToString();
                    item.Jugador2 = lector["jugador2"].ToString();
                    item.Puntaje1 = int.Parse(lector["puntaje1"].ToString());
                    item.Puntaje2 = int.Parse(lector["puntaje2"].ToString());
                    item.Ganador = lector["ganador"].ToString();

                    lista.Add(item);
                }

                lector.Close();

            }
            catch (Exception)
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

        public bool AgregarDato(PartidaTerminada param)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO dbo.historialPartidas (jugador1, jugador2, puntaje1, puntaje2, ganador ) VALUES(";
                sql = sql + "'" + param.Jugador1 + "','" + param.Jugador2 + "'," + param.Puntaje1 + "," + param.Puntaje2 + ",'" +
                param.Ganador + "')";

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
