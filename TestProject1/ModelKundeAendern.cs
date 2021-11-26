using System;
using System.Collections.Generic;
using System.Text;
using HHBK_Chemicals_ERP_CS;
using HHBK_Chemicals_ERP_CS.model;

//Fuer den Test hinzugefügt:
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProject1
{

    [TestClass]
    class ModelKundeAendern
    {
        [TestMethod]
        void ModelKundenlisteXML_alter_Kunde_GeaenderterKunde() {
            //Arrange
            IKundenliste kl = new KundenlisteXML();

            Kunde testkunde = 
                new Kunde(69, "von Hinten", "Reinhardt", "Reperbahn", "1a", "DuEselDorf", 40225, "hotboy@ice.com");

            kl.save(testkunde);



            Console.ReadKey();
        //Act

        
        //Assert
        
        
        }
    }
}
