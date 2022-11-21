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
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void TestCinqPlusUnité(int nombreArabe)
        {
            // ETANT DONNE un nombre <nombreArabe> compris entre 5 et 8
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(nombreArabe);

            // ALORS on obtient 'V' plus <nombreArabe - 5> fois 'I'
            var attendu = 'V' + new string('I', nombreArabe - 5);
            Assert.Equal(attendu, resultat);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        public void TestDixPlusUnité(int nombreArabe)
        {
            // ETANT DONNE un nombre <nombreArabe> compris entre 10 et 10
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(nombreArabe);

            // ALORS on obtient 'X' plus <nombreArabe - 10> fois 'I'
            var attendu = 'X' + new string('I', nombreArabe - 10);
            Assert.Equal(attendu, resultat);
        }
    }
}