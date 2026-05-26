using System;
using Microsoft.VisualStudio.TestTools.UnitTesting; 

[TestClass] 
public class ProgrammationTests
{
    [DataTestMethod] 
    [DataRow(10, 20, 30)] // (Param1, Param2, ResultatAttendu)
    public void TestMonCalcul(int a, int b, int resultatAttendu)
    {
        // Act : Appel de ta fonction
        int resultatObtenu = Program.MaFonction(a, b);
        
        // Assert : Vérification
        Assert.AreEqual(resultatAttendu, resultatObtenu);
    }

    [TestMethod]
    public void TestException()
    {
        // Vérifie qu'une erreur est bien lancée pour une valeur invalide
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
            Program.MaFonction(-1, 0); 
        });
    }
}
