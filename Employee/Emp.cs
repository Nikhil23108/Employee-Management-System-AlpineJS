using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Employee;

[Table("EMP")]
public class Emp
{
    [Key]
    [Column("EMPNO")]
    public int Id { get; set; }

    public string ENAME { get; set; } = string.Empty;

    public string JOB { get; set; } = string.Empty;

    public int? MGR { get; set; }

    public DateOnly HIREDATE { get; set; }

    public decimal? SAL { get; set; }

    public decimal? COMM { get; set; }

    [Column("DEPTNO")]
    public int? DEPTID { get; set; }

    [ForeignKey("DEPTID")]
    public Dept? Department { get; set; }
}