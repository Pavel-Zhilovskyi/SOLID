namespace ChemicalLab;

internal interface IReportGenerator
{
    void GenerateReport(Sample sample, bool success);
}
