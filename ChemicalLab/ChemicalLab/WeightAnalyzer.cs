namespace ChemicalLab;

internal class WeightAnalyzer : IWeightAnalyzer
{
    public bool Analyze(Sample sample)
    {
        if (sample.Weight > 0 && sample.Weight <= 50)
        {
            return true;
        }
        return false;
    }
}