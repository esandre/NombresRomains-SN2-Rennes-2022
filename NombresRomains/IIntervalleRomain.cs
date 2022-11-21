namespace NombresRomains
{
    internal interface IIntervalleRomain
    {
        string Représenter(int nombreArabe);

        IIntervalleRomain Suivant { get; }

        int LimiteSupérieureInclusive { get; }
    }
}
