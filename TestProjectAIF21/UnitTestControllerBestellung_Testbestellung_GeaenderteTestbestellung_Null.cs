using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HHBK_Chemicals_ERP_CS;

namespace TestProjectAIF21
{
    [TestClass]
    class UnitTestControllerBestellung_testbestellung_geaenderteTestbestellung_Null
    {
        [TestMethod]
        public void Controller_Bestellung()
        {
            //Arrange
            IController_Bestellung  controllerBestellung = new ControllerBestellung();
            Bestellung testbestellung = new Bestellung();
            testbestellung.Bestellungsnummer = 4711;
            //...
Bestellung geaenderteTestbestellung = new Bestellung();
            geaenderteTestbestellung.Bestellungsnummer = 4711;
            //...

            //Act
            int rueckgabe = controllerBestellung.Andern(testbestellung, geaenderteTestbestellung);
        
            //Assert
            Assert.AreEqual(0, rueckgabe);
        }
    }
}
