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

        [Fact]
        public void Test4()
        {
            // ETANT DONNE le nombre 4
            const int nombreArabe = 4;
            
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(nombreArabe);

            // ALORS on obtient 'IV'
            Assert.Equal("IV", resultat);
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

        [Fact]
        public void Test9()
        {
            // ETANT DONNE le nombre 9
            const int nombreArabe = 9;

            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(nombreArabe);

            // ALORS on obtient 'IX'
            Assert.Equal("IX", resultat);
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

        [Fact]
        public void Test14()
        {
            // ETANT DONNE le nombre 14
            const int nombreArabe = 14;

            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombresRomains.Convertir(nombreArabe);

            // ALORS on obtient 'XIV'
            Assert.Equal("XIV", resultat);
        }
    }
}