namespace ChemicalLab;

internal class RemoteDBReportGenerator : IReportGenerator
{
    public void GenerateReport(Sample sample, bool success)
    {
        Console.WriteLine($"Sending report for sample '{sample.Name}' to remote database. Success: {success}");
    }
}