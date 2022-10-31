using Models;
namespace Business;
public class EmployeesBAL : IEmployeesBAL
{
    private readonly IEmployeesDAL dal;

    public EmployeesBAL(IEmployeesDAL dal)
    {
        this.dal = dal;
    }
    public async Task<IEnumerable<Employee>> GetEmployees()
    {
        var res=await dal.GetEmployees();
        return res;
    }

    public async Task<ActivityResponse> Save_Employee(Employee emp)
    {
        var res=await dal.Save_Employee(emp);
        return res;
    }

    public async Task<Employee> GetEmployeeById(Int32 Id)
    {
         var res=await dal.GetEmployeeById(Id);
        return res;
    }
}
