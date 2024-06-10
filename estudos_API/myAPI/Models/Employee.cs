using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myAPI.Models
{
    [Table("tbl_employee")]
    public class Employee
    {
        [Key]
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Photo { get; private set; }

        public Employee(string _name, int _age, string _photo)
        {
            Name = _name;
            Age = _age;
            Photo = _photo;
        }
    }
}