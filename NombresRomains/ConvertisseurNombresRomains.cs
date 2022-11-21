namespace NombresRomains
{
    public static class ConvertisseurNombresRomains
    {
        public static string Convertir(int nombreArabe)
            => nombreArabe switch
               {
                   <= 3  => NombreRomain.Unité.AfficherSuite(nombreArabe),
                   4     => NombreRomain.Cinq.Prédécesseur,
                   <= 8  => NombreRomain.Cinq.AfficherSuite(nombreArabe),
                   9     => NombreRomain.Dix.Prédécesseur,
                   <= 13 => NombreRomain.Dix.AfficherSuite(nombreArabe),
                   14    => NombreRomain.Quinze.Prédécesseur,
                   <= 18 => NombreRomain.Quinze.AfficherSuite(nombreArabe),
                   19    => NombreRomain.Vingt.Prédécesseur,
                   <= 23 => NombreRomain.Vingt.AfficherSuite(nombreArabe),
                   24    => NombreRomain.VingtCinq.Prédécesseur,
                   <= 28 => NombreRomain.VingtCinq.AfficherSuite(nombreArabe),
                   29    => NombreRomain.Trente.Prédécesseur,
                   <= 34 => NombreRomain.Trente.AfficherSuite(nombreArabe),
                   _     => throw new NotImplementedException()
               };
    }
}
