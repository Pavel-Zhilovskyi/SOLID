namespace ChemicalLab;

internal class RadiationAnalyzer : IRadiationAnalyzer   
{
    public bool Analyze(Sample sample)
    {
        if (sample.Radioactivity <= 500)
        {
            return true;
        }
        return false;
    }
}