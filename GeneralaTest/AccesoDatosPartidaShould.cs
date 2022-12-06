using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ClaseParcial2;

namespace GeneralaTest
{
    [TestClass]
    public class AccesoDatosPartidaShould
    {
        [TestMethod]
        public void RetornarTrueYConectarseALaBaseDeDatos()
        {
            //arrange
            AccesoDatosPartida baseDeDatos = new AccesoDatosPartida();
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
            AccesoDatosPartida baseDeDatos = new AccesoDatosPartida();
            List<PartidaTerminada> lista = new List<PartidaTerminada>();
            //act
            lista = baseDeDatos.ObtenerListaDato();
            //assert
            Assert.IsNotNull(lista);
        }

        [TestMethod]
        public void AgregarLaPartidaTerminadaPasadaPorParametroYRetornarTrue()
        {
            //arrange
            AccesoDatosPartida baseDeDatos = new AccesoDatosPartida();
            PartidaTerminada partida = new PartidaTerminada("Nahuel", "Pazos", 1, 0, "Nahuel");
            bool resultado;
            //act
            resultado = baseDeDatos.AgregarDato(partida);
            //assert
            Assert.IsTrue(resultado);
        }
    }
}

