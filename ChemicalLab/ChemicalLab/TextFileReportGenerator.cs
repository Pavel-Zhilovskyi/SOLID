namespace ChemicalLab;

internal class TextFileReportGenerator : IReportGenerator
{
    private string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Report.txt");

    public void GenerateReport(Sample sample, bool success)
    {
        if(success)
        {
            string text = $"Experiment successful for sample: {sample.Name}\n\n";
            File.AppendAllText(_filePath, text);
        }
        else
        {
            string text = $"Experiment failed for sample: {sample.Name}\n\n";
            File.AppendAllText(_filePath, text);
        }
    }
}