using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Employee;

[Table("DEPT")]
public class Dept
{
    [Key]
    [Column("DEPTNO")]
    public int Id { get; set; }

    public string DNAME { get; set; } = string.Empty;

    public string LOC { get; set; } = string.Empty;

    public ICollection<Emp> Employees { get; set; } = new List<Emp>();
}