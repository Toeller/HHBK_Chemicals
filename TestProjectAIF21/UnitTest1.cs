using Microsoft.VisualStudio.TestTools.UnitTesting;
using HHBK_Chemicals_ERP_CS;

namespace TestProjectAIF21
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
        }

        [TestMethod]
        public void Icontroller_Test()
        {
            IController_Bestellung controller_Bestellung = new ControllerBestellung();

            int a = controller_Bestellung.Anlegen(new Bestellung(), new Kunde(5, "alma", "repa", "stasse", "asd", "HH", 55555, "a@gamil.com"));
            int b = controller_Bestellung.Andern(new Bestellung(), new Bestellung());
            Assert.AreEqual(0, a);
            Assert.AreEqual(0, b);
        }
    }
}
