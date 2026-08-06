namespace ChemicalLab;

internal abstract class Experiment
{
    public Sample Sample { get; }
    
    protected Experiment(Sample sample)
    {
        Sample = sample;
    }

    public abstract bool RunExperiment();
}