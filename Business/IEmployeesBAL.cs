using Models;

public interface IEmployeesBAL
{
    Task<IEnumerable<Employee>> GetEmployees();
    Task<Employee> GetEmployeeById(Int32 Id);
    Task<ActivityResponse> Save_Employee(Employee emp);
}