using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClaseParcial2;
using System.Collections.Generic;

namespace GeneralaTest
{
    [TestClass]
    public class AccesoDatosShould
    {
        [TestMethod]
        public void RetornarTrueYConectarseALaBaseDeDatos()
        {
            //arrange
            AccesoDatos baseDeDatos = new AccesoDatos();
            bool resultado;
            //act
            resultado = baseDeDatos.ProbarConexion();
            //assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void RetornarLaListaDeLaBaseDeDatos()
        {
            //arrange
            AccesoDatos baseDeDatos = new AccesoDatos();
            List<JugadorPersona> lista = new List<JugadorPersona>();
            //act
            lista = baseDeDatos.ObtenerListaDato();
            //assert
            Assert.IsNotNull(lista);
        }

        [TestMethod]
        public void AgregarAlJugadorPasadoPorParametroYRetornarTrue()
        {
            //arrange
            AccesoDatos baseDeDatos = new AccesoDatos();
            JugadorPersona jugador = new JugadorPersona("Nahuel","Pazos","NahuPazos","123N",0,0,0);
            bool resultado;
            //act
            resultado = baseDeDatos.AgregarDato(jugador);
            //assert
            Assert.IsTrue(resultado);
        }

        /*[TestMethod]
        public void ModificarAlJugadorPasadoPorParametroYRetornarTrue()
        {
            //arrange
            AccesoDatos baseDeDatos = new AccesoDatos();
            JugadorPersona jugador = new JugadorPersona("Rodrigo", "Pazos", "NahuPazos", "123Nn", 1, 1, 2);
            bool resultado;
            //act
            resultado = baseDeDatos.ModificarDato(jugador);
            //assert
            Assert.IsTrue(resultado);
        }*/

    }
}
