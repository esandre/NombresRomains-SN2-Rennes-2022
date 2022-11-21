namespace NombresRomains.Test
{
    public class NombresRomainsTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void TestUnités(int n)
        {
            // ETANT DONNE un nombre <n> compris entre 1 et 3
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(n);

            // ALORS on obtient <n> fois 'I'
            var attendu = new string('I', n);
            Assert.Equal(attendu, resultat);
        }

        [Theory]
        [InlineData(4, "V")]
        [InlineData(9, "X")]
        [InlineData(14, "XV")]
        public void TestPrédécesseur(int nombreArabe, string symboleSuivant)
        {
            // ETANT DONNE le nombre <nombreArabe>, prédécesseur d'un multiple de 5
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(nombreArabe);

            // ALORS 'I' est ajouté en avant-dernière position de <symboleSuivant>
            var attendu = symboleSuivant.Insert(symboleSuivant.Length - 1, "I");
            Assert.Equal(attendu, resultat);
        }

        [Theory]
        [InlineData(5, "V", 5)]
        [InlineData(6, "V", 5)]
        [InlineData(7, "V", 5)]
        [InlineData(8, "V", 5)]
        [InlineData(10, "X", 10)]
        [InlineData(11, "X", 10)]
        [InlineData(12, "X", 10)]
        [InlineData(13, "X", 10)]
        [InlineData(15, "XV", 15)]
        [InlineData(16, "XV", 15)]
        [InlineData(17, "XV", 15)]
        [InlineData(18, "XV", 15)]
        public void TestSymbolePlusUnité(int nombreArabe, string symbole, int valeurSymbole)
        {
            // ETANT DONNE un nombre <nombreArabe> compris entre <valeurSymbole> et <valeurSymbole> + 3
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(nombreArabe);

            // ALORS on obtient <symbole> plus <nombreArabe - valeurSymbole> fois 'I' 
            var attendu = symbole + new string('I', nombreArabe - valeurSymbole);
            Assert.Equal(attendu, resultat);
        }
    }
}