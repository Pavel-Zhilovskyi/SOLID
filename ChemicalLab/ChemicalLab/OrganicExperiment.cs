namespace ChemicalLab;

internal class OrganicExperiment : Experiment
{
    private readonly IRadiationAnalyzer _analyzer;

    public OrganicExperiment(Sample sample, IRadiationAnalyzer analyzer) : base(sample)
    {
        _analyzer = analyzer;
    }

    public override bool RunExperiment()
    {
        Console.WriteLine("Performing organic experiment if we can keep the sample in open world...");
        return _analyzer.Analyze(Sample);
    }
}