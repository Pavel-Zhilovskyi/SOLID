using ChemicalLab;

internal class ChemicalAnalyzer : IChemicalAnalyzer
{
    public bool Analyze(Sample sample)
    {
        if(sample.Toxicity <= 50)
        {
            return true;
        }
        return false;
    }
}