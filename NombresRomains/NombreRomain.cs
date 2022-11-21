namespace NombresRomains
{
    internal class NombreRomain
    {
        private readonly string _representation;
        private readonly int _valeur;

        public static readonly NombreRomain Unité = new ("I", 1);
        public static readonly NombreRomain Cinq = new ("V", 5);
        public static readonly NombreRomain Dix = new ("X", 10);
        public static readonly NombreRomain Quinze = new ("XV", 15);

        private NombreRomain(string representation, int valeur)
        {
            _representation = representation;
            _valeur = valeur;
        }

        public string Prédécesseur
        {
            get
            {
                var préfixe = _representation[..^1];
                var suffixe = _representation.Last();
                return préfixe + Unité + suffixe;
            }
        }

        public string AfficherSuite(int nombreArabe)
        {
            return _representation + new string('I', nombreArabe - _valeur);
        }

        /// <inheritdoc />
        public override string ToString() => _representation;
    }
}
