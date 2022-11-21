namespace NombresRomains
{
    internal class UnitéRomaine : IIntervalleRomain
    {
        public static UnitéRomaine Unité => new UnitéRomaine();

        private UnitéRomaine()
        {
        }

        /// <inheritdoc />
        public string Représenter(int nombreArabe) => new string('I', nombreArabe);

        /// <inheritdoc />
        public IIntervalleRomain Suivant => PenteRomaine.Cinq;

        /// <inheritdoc />
        public int LimiteSupérieureInclusive => 3;

        /// <inheritdoc />
        public override string ToString() => Représenter(1);
    }
}
