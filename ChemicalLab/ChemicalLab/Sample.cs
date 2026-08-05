namespace ChemicalLab;

internal abstract class Sample
{
    public string Name { get; }
    public int Weight { get; }
    public int Temperature { get; }
    public int Radioactivity { get; }
    public int Toxicity { get; }

    protected Sample(string name, int weight, int temperature, int radioactivity, int toxicity)
    {
        Name = name;
        Weight = weight;
        Temperature = temperature;
        Radioactivity = radioactivity;
        Toxicity = toxicity;
    }
}