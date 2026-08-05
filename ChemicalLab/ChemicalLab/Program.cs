namespace ChemicalLab;

internal class Program
{
    static void Main(string[] args)
    {
        Sample uraniumSample = new Uranium("Uranium-235", 100, 25, 1000, 100);

        ITemperatureAnalyzer temperatureAnalyzer = new TemperatureAnalyzer();
        IRadiationAnalyzer radiationAnalyzer = new RadiationAnalyzer();
        IChemicalAnalyzer chemicalAnalyzer = new ChemicalAnalyzer();

        IReportGenerator reportGenerator = new TextFileReportGenerator();

        Experiment uraniumExperiment = new HazardousMaterialExperiment(uraniumSample, temperatureAnalyzer, radiationAnalyzer);

        var manager = new ExperimentManager(reportGenerator);

        manager.ConductExperiment(uraniumExperiment);

        Sample saltSample = new Salt("Salt", 100, 25, 1, 25);

        Experiment organicExperiment = new OrganicExperiment(saltSample, radiationAnalyzer);

        manager.ConductExperiment(organicExperiment);

        Sample heatedSaltSample = new Salt("Salt", 100, 1000, 1, 25);

        Experiment heatedSaltExperiment = new HazardousMaterialExperiment(heatedSaltSample, temperatureAnalyzer, radiationAnalyzer);

        manager.ConductExperiment(heatedSaltExperiment);

        Sample saltSample2 = new Salt("Salt", 100, 25, 1, 25);

        Experiment organicExperiment2 = new ChemicalExperiment(saltSample2, chemicalAnalyzer);

        manager.ConductExperiment(organicExperiment2);
    }
}