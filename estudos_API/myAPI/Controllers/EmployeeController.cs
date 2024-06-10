using Microsoft.AspNetCore.Mvc;
using myAPI.Models;
using myAPI.ViewModel;

namespace myAPI.Controllers
{
    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository ?? throw new ArgumentNullException();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employess = _employeeRepository.GetEmployees();
            return Ok(employess);
        }

        [HttpPost]
        public IActionResult Post(EmployeeViewModel employeeView)
        {
            var employee = new Employee(employeeView.Name, employeeView.Age, null);
            _employeeRepository.AddEmployee(employee);
            return Ok("Funcionário adicionado com sucesso");
        }
    }
}