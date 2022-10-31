using Models;

namespace DataAccess;
public class EmployeesDAL : IEmployeesDAL
{
    public async Task<Employee> GetEmployeeById(Int32 Id)
    {
        List<Employee> lst = new List<Employee>();
        lst.Add(new Employee()
        {
            Id = 100,
            Name = "Ravish Singh",
            Father_Name="Ravish Ke Papa",
            DOB=DateTime.Now.AddYears(-56),
            Address= new Address(),
        });

        return lst.Where(p=>p.Id==Id).FirstOrDefault();
    }

    public async Task<IEnumerable<Employee>> GetEmployees()
    {
         List<Employee> lst = new List<Employee>();
        lst.Add(new Employee()
        {
            Id = 100,
            Name = "Ravish Singh",
            Father_Name="Ravish Ke Papa",
            DOB=DateTime.Now.AddYears(-56),
            Address= new Address(),
        });

        lst.Add(new Employee()
        {
            Id = 101,
            Name = "Halka Bhai",
            Father_Name="Halka Ke Papa",
            DOB=DateTime.Now.AddYears(-20),
            Address= new Address(),
        });
        return lst;
    }

    public async Task<ActivityResponse> Save_Employee(Employee emp)
    {
        throw new NotImplementedException();
    }
}
