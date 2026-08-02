using ISPGood;

namespace ISPGood;

internal class Office
{
    public int enteredEmployeesCount { get; private set; }

    public void AllowEntry(IOfficeAccess employee)
    {
        employee.AccessOffice();
        enteredEmployeesCount++;
    }
}
