using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClaseParcial2;
using System.Collections.Generic;
using System;

namespace GeneralaTest
{
    [TestClass]
    public class DadoShould
    {
        [TestMethod]
        public void ComprobarQueLaJugadaSeaGeneralaYRetornarTrue()
        {
            //arrange
            int[] dados = new int[6];
            dados[0] = 5;
            dados[1] = 0;
            dados[2] = 0;
            dados[3] = 0;
            dados[4] = 0;
            dados[5] = 0;
            //act
            bool esGenerala = Dado.Generala(dados);
            //Assert
            Assert.IsTrue(esGenerala);
        }

        [TestMethod]
        public void ComprobarQueLaJugadaSeaPokerYRetornarTrue()
        {
            //arrange
            int[] dados = new int[6];
            dados[0] = 4;
            dados[1] = 0;
            dados[2] = 1;
            dados[3] = 0;
            dados[4] = 0;
            dados[5] = 0;
            //act
            bool esPoker = Dado.Poker(dados);
            //Assert
            Assert.IsTrue(esPoker);
        }

        [TestMethod]
        public void ComprobarQueLaJugadaSeaFullYRetornarTrue()
        {
            //arrange
            int[] dados = new int[6];
            dados[0] = 0;
            dados[1] = 0;
            dados[2] = 0;
            dados[3] = 0;
            dados[4] = 3;
            dados[5] = 2;
            //act
            bool esFull = Dado.Full(dados);
            //Assert
            Assert.IsTrue(esFull);
        }

        [TestMethod]
        public void ComprobarQueLaJugadaSeaEscaleraYRetornarTrue()
        {
            //arrange
            List<int> dados = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                dados.Add(i+1);
            }
            //act
            bool esEscalera = Dado.Escalera(dados);
            //Assert
            Assert.IsTrue(esEscalera);
        }

    }
}
