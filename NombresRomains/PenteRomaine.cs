namespace NombresRomains
{
    internal class PenteRomaine : IIntervalleRomain
    {
        private readonly string _representation;
        private readonly int _valeur;

        private static readonly IIntervalleRomain Unité = UnitéRomaine.Unité;
        internal static readonly IIntervalleRomain Cinq = new PenteRomaine("V", 5);
        
        private IIntervalleRomain IntervalleSuivant
        {
            get
            {
                if (_valeur == 35) return new PenteRomaine("XL", 40);

                var dernierCaractère = _representation.Last();
                var représentationSuivante = dernierCaractère == 'V'
                    ? _representation[..^1] + 'X'
                    : _representation + 'V';

                return new PenteRomaine(représentationSuivante, _valeur + 5);
            }
        }

        /// <inheritdoc />
        public int LimiteSupérieureInclusive => _valeur + 3;

        private PenteRomaine(string representation, int valeur)
        {
            _representation = representation;
            _valeur = valeur;
        }

        private string Prédécesseur
        {
            get
            {
                var préfixe = _representation[..^1];
                var suffixe = _representation.Last();
                return préfixe + Unité + suffixe;
            }
        }

        public string Représenter(int nombreArabe)
        {
            if (nombreArabe == _valeur - 1) return Prédécesseur;
            return _representation + Unité.Représenter(nombreArabe - _valeur);
        }

        /// <inheritdoc />
        IIntervalleRomain IIntervalleRomain.Suivant => IntervalleSuivant;

        /// <inheritdoc />
        public override string ToString() => _representation;
    }
}
