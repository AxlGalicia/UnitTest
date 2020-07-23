using Microsoft.VisualStudio.TestTools.UnitTesting;
using helloworld;
namespace mstest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Se inicializa la prueba con el parametro esperado en la respuesta del metodo test()
            var resultado = true;

            //Se instancia un objeto de la clase Program
            Program o = new Program();
            //Se realiza la prueba del metodo
            var result = o.test(2);
            //Se comprueba los resultados de la prueba
            Assert.AreEqual(resultado,result);
        }
    }
}
