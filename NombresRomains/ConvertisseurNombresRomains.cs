namespace NombresRomains
{
    public static class ConvertisseurNombresRomains
    {
        public static string Convertir(int nombreArabe)
            => nombreArabe switch
               {
                   <= 53 => UnitéRomaine.Unité.ReprésenterSoiMêmeOuDemanderAuSuivant(nombreArabe),
                   _     => throw new NotImplementedException()
               };
    }
}
