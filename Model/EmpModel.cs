using DemoApp.Employee;
using System.Collections.Generic;
using System.Linq;

namespace DemoApp.Model;

public class EmpModel
{
    public List<Emp> FetchEmployees()
    {
        using var ctx = new EmployeeDbContext();
        return ctx.Employees.ToList();
    }

    // Fixed: Passing whole object cleanly maps directly to EF types
    public void AcceptEmployee(Emp emp)
    {
        using var ctx = new EmployeeDbContext();
        ctx.Employees.Add(emp);
        ctx.SaveChanges();
    }

    // Fixed: Directly updates properties matching your precise decimal/DateOnly schema
    public bool ModifyEmployee(int id, Emp updatedData)
    {
        using var ctx = new EmployeeDbContext();
        var existingEmp = ctx.Employees.Find(id);
        if (existingEmp == null) return false;

        existingEmp.ENAME = updatedData.ENAME;
        existingEmp.JOB = updatedData.JOB;
        existingEmp.MGR = updatedData.MGR;
        existingEmp.HIREDATE = updatedData.HIREDATE;
        existingEmp.SAL = updatedData.SAL;
        existingEmp.COMM = updatedData.COMM;
        existingEmp.DEPTID = updatedData.DEPTID;

        ctx.SaveChanges();
        return true;
    }

    public bool DeleteEmployee(int id)
    {
        using var ctx = new EmployeeDbContext();
        var emp = ctx.Employees.Find(id);
        if (emp == null) return false;

        ctx.Employees.Remove(emp);
        ctx.SaveChanges();
        return true;
    }
}