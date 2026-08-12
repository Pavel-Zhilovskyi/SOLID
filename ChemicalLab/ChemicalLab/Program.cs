namespace ChemicalLab;

internal class Program
{
    static void Main(string[] args)
    {
        Sample uraniumSample = new Sample("Uranium-235", 100, 25, 1000, 100);

        IRadiationAnalyzer radiationAnalyzer = new RadiationAnalyzer();
        IChemicalAnalyzer chemicalAnalyzer = new ChemicalAnalyzer();

        IReportGenerator reportGenerator = new TextFileReportGenerator();

        Experiment uraniumExperiment = new HazardousMaterialExperiment(uraniumSample, chemicalAnalyzer, radiationAnalyzer);

        var manager = new ExperimentManager(reportGenerator);

        manager.ConductExperiment(uraniumExperiment);

        Sample saltSample = new Sample("Salt", 100, 25, 0, 25);

        Experiment organicExperiment = new OrganicExperiment(saltSample, radiationAnalyzer);

        manager.ConductExperiment(organicExperiment);

        Sample heatedSaltSample = new Sample("Heated salt", 100, 1000, 0, 25);

        Experiment heatedSaltExperiment = new HazardousMaterialExperiment(heatedSaltSample, chemicalAnalyzer, radiationAnalyzer);

        manager.ConductExperiment(heatedSaltExperiment);

        Sample saltSample2 = new Sample("Salt", 100, 25, 15, 25);

        Experiment organicExperiment2 = new ChemicalExperiment(saltSample2, chemicalAnalyzer);

        manager.ConductExperiment(organicExperiment2);

        Sample steel = new Sample("Steel", 50, 28, 0, 15);

        Experiment normalSteelExperiment = new HazardousMaterialExperiment(steel, chemicalAnalyzer, radiationAnalyzer);

        manager.ConductExperiment(normalSteelExperiment);
    }
}