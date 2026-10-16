using ActividadTDDApp;
namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        [DataRow(-5, -1)]   //Factorial -1
        [DataRow(0, 1)]     //Factorial 1
        [DataRow(4, 24)]    //Factorial correcto
        public void CalcularFactorialTest(int n, long nEsperado)
        {
            long result = Funciones.CalcularFactorial(n);
            Assert.AreEqual(nEsperado, result);
        }
    }
}
