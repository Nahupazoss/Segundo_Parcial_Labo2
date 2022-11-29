using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClaseParcial2;

namespace GeneralaTest
{
    [TestClass]
    public  class JugadorPersonaShould
    {
        [TestMethod]
        [DataRow("HOLA")]
        [DataRow("HOLA1")]
        [DataRow("123a")]
        public void VerificarQueLasContraseñasSeanIgualesYFuncione(string password)
        {
            //arrange
            JugadorPersona jugadorPersona = new JugadorPersona();
            jugadorPersona.Password = "123a";
            bool resultado;
            //act
            resultado = jugadorPersona.CheckearPassword(password);
            //assert
            Assert.AreEqual(jugadorPersona.Password == password,resultado);
        }
    }
}
