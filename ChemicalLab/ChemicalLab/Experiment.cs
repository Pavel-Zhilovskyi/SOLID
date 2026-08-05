namespace ChemicalLab;

internal abstract class Experiment
{
    public Sample Sample { get; }
    public abstract bool RunExperiment();
    
    protected Experiment(Sample sample)
    {
        Sample = sample;
    }
}