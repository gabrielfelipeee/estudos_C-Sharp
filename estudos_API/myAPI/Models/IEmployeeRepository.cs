namespace myAPI.Models
{
    public interface IEmployeeRepository
    {
        void AddEmployee(Employee employee);
        List<Employee> GetEmployees();
    }
}
