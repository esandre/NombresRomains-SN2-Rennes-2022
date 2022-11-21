namespace NombresRomains
{
    internal static class IntervalleRomainExtensions
    {
        public static string ReprésenterSoiMêmeOuDemanderAuSuivant(this IIntervalleRomain intervalle, int nombreArabe)
            => nombreArabe <= intervalle.LimiteSupérieureInclusive
                ? intervalle.Représenter(nombreArabe)
                : intervalle.Suivant.ReprésenterSoiMêmeOuDemanderAuSuivant(nombreArabe);
    }
}