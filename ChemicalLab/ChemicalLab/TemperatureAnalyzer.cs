namespace ChemicalLab;

internal class TemperatureAnalyzer : ITemperatureAnalyzer
{
    public bool Analyze(Sample sample)
    {
        if (sample.Temperature > 0 && sample.Temperature <= 60)
        {
            return true;
        }
        return false;
    }
}