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

        private static IEnumerable<(string Symbole, int Valeur)> Symboles => new[]
        {
            ("V", 5),
            ("X", 10),
            ("XV", 15),
            ("XX", 20),
            ("XXV", 25),
            ("XXX", 30),
        };

        // Pour chaque symbole on renvoie le prédécesseur.
        // Exemple pour XX : XIX
        private static IEnumerable<object[]> CasTestPrédécesseurGenerator()
            => Symboles.Select(symbole => new object[] { symbole.Valeur - 1, symbole.Symbole });

        private static IEnumerable<object[]> CasTestSymbolePlusUnitéGenerator()
        {
            // Pour chaque symbole, on renvoie les 3 suivants.
            // Exemple pour XV : XV, XVI, XVII, XVIII.
            foreach (var (symbole, valeur) in Symboles)
            {
                yield return new object[] { valeur, symbole, valeur };
                yield return new object[] { valeur + 1, symbole, valeur };
                yield return new object[] { valeur + 2, symbole, valeur };
                yield return new object[] { valeur + 3, symbole, valeur };
            }
        }

        public static object[][] CasTestSymbolePlusUnité => CasTestSymbolePlusUnitéGenerator().ToArray();
        public static object[][] CasTestPrédécesseur => CasTestPrédécesseurGenerator().ToArray();

        [Theory]
        [MemberData(nameof(CasTestSymbolePlusUnité))]
        public void TestSymbolePlusUnité(int nombreArabe, string symbole, int valeurSymbole)
        {
            // ETANT DONNE un nombre <nombreArabe> compris entre <valeurSymbole> et <valeurSymbole> + 3
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(nombreArabe);

            // ALORS on obtient <symbole> plus <nombreArabe - valeurSymbole> fois 'I' 
            var attendu = symbole + new string('I', nombreArabe - valeurSymbole);
            Assert.Equal(attendu, resultat);
        }

        [Theory]
        [MemberData(nameof(CasTestPrédécesseur))]
        public void TestPrédécesseur(int nombreArabe, string symboleSuivant)
        {
            // ETANT DONNE le nombre <nombreArabe>, prédécesseur d'un multiple de 5
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(nombreArabe);

            // ALORS 'I' est ajouté en avant-dernière position de <symboleSuivant>
            var attendu = symboleSuivant.Insert(symboleSuivant.Length - 1, "I");
            Assert.Equal(attendu, resultat);
        }
    }
}