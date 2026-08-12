namespace ChemicalLab;

internal class HazardousMaterialExperiment : Experiment
{
    private readonly IChemicalAnalyzer _chemicalAnalyzer;
    private readonly IRadiationAnalyzer _radiationAnalyzer;

    public HazardousMaterialExperiment(Sample sample, IChemicalAnalyzer analyzer, IRadiationAnalyzer radiationAnalyzer) 
        : base(sample)
    {
        _chemicalAnalyzer = analyzer;
        _radiationAnalyzer = radiationAnalyzer;
    }

    public override bool RunExperiment()
    {
        Console.WriteLine("Performing danger experiment if we can keep the sample without protection...");

        return _radiationAnalyzer.Analyze(Sample)
       && _chemicalAnalyzer.Analyze(Sample);
    }
}