using BLL;
namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDuCalculeDelaMoyenne()
        {
            Assert.Pass();
         
            Vente vente = new Vente() 
            { 
                TypeVehicule = new Vehicule() { TypeVehicule="Autobus"},
                NomProvince = new Province() { NomProvince="Québec"},
                Annee = 2011,
                MntPar1000 = 1000,
                NbUnites = 100
            };
            vente.CalculerPrixMoyenPar1000();

            Assert.NotNull(vente.PrixMoyenPar1000);
            Assert.AreEqual(vente.PrixMoyenPar1000, (1000/100));
            Assert.IsNaN(vente.PrixMoyenPar1000);
            

            
        }
    }
}