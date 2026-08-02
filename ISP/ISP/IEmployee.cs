namespace ISPBad;

internal interface IEmployee
{
    void StartWork();
    void EndWork();
    void RequestVocation();
    void ApproveVocation();
    void AccessOffice();
    void LogWorkingHours();
    void GeneratePayroll();
}