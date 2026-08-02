using ISPBad;

namespace ISPBad;

internal class Office
{
    public int enteredEmployeesCount { get; private set; }

    //public void OpenOffice(List<IEmployee> employees)
    //{
    //    foreach (var employee in employees)
    //    {
    //        employee.AccessOffice();
    //    }
    //}

    public void AllowEntry(IEmployee employee)
    {
        employee.AccessOffice();
        enteredEmployeesCount++;
    }
}
