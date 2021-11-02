using System;
using System.Collections.Generic;
using System.Text;
using HHBK_Chemicals_ERP_CS;
//Fürs Testen:
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    class UnitTestModelKunde
    {
        [TestMethod]
        public void getKunden_Void_ReturnsKundenListe()
        {
            //Arrange
            IModel model = new Model();
            //Act

            var res = model.getKunden();

            //Assert



        }

    }
}
