using Models;

public interface IEmployeesDAL
{
    Task<IEnumerable<Employee>> GetEmployees();
    Task<Employee> GetEmployeeById(Int32 Id);
    Task<ActivityResponse> Save_Employee(Employee emp);
}