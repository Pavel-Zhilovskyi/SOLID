namespace ChemicalLab;

internal class HazardousMaterialExperiment : Experiment
{
    private readonly ITemperatureAnalyzer _temperatureAnalyzer;
    private readonly IRadiationAnalyzer _radiationAnalyzer;

    public HazardousMaterialExperiment(Sample sample, ITemperatureAnalyzer analyzer, IRadiationAnalyzer radiationAnalyzer  ) : base(sample)
    {
        _temperatureAnalyzer = analyzer;
        _radiationAnalyzer = radiationAnalyzer;
    }

    public override bool RunExperiment()
    {
        Console.WriteLine("Performing danger experiment if we can keep the sample without protection...");

        return _radiationAnalyzer.Analyze(Sample)
       && _temperatureAnalyzer.Analyze(Sample);
    }
}