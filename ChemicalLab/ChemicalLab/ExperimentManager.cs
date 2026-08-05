namespace ChemicalLab;

internal class ExperimentManager
{
    private readonly IReportGenerator _reportGenerator;
    public ExperimentManager(IReportGenerator reportGenerator)
    {
        _reportGenerator = reportGenerator;
    }
    public void ConductExperiment(Experiment _experiment)
    {
        bool success = _experiment.RunExperiment();
        _reportGenerator.GenerateReport(_experiment.Sample, success);
    }
}