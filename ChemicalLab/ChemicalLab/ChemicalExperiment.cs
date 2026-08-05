namespace ChemicalLab;

internal class ChemicalExperiment : Experiment
{
    private readonly IChemicalAnalyzer _chemicalAnalyzer;
    public ChemicalExperiment(Sample sample, IChemicalAnalyzer chemicalAnalyzer) : base(sample)
    {
        _chemicalAnalyzer = chemicalAnalyzer;
    }
    public override bool RunExperiment()
    {
        Console.WriteLine("Performing chemical experiment...");

        return _chemicalAnalyzer.Analyze(Sample);
    }
}