using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClaseParcial2;

namespace GeneralaTest
{
    [TestClass]
    public class ValidadorShould
    {
        [TestMethod]
        public void RetornarTrueCuandoElTextoSeaValido()
        {
            //arrange
            string nombre = "Nahuel";
            bool resultado;
            //act
            resultado = Validador.ValidarTexto(nombre);
            //assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void RetornarFalseCuandoElTextoSeaInvalido()
        {
            //arrange
            string nombre = " ";
            bool resultado;
            //act
            resultado = Validador.ValidarTexto(nombre);
            //assert
            Assert.IsFalse(resultado);
        }
    }
}
