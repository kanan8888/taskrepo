using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9_17october
{
    public class Department
    {
        static int NO;

        int _no=NO;
        int _employeeLimit;
        Employee[] _employees = new Employee[0];

        public Department( int employeeLimit)
        {
            _employeeLimit = employeeLimit;
            NO++;
        }



        void AddEmployee(Employee employee) 
        {
            if (_employeeLimit <= _employees.Length + 1)
            {
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[_employees.Length] = employee;
            }
        }
        Employee GetEmployee(int id) 
        {
            foreach (Employee emp in _employees)
            {
                if (emp.Id == id)
                {
                    return emp;
                }
            }
            return null;
        }
        void GetEmployeeInfo(int id) 
        {
            Console.WriteLine(GetEmployee(id).ToString); 
        }
        void GetAllEmployees() 
        {
            foreach (Employee emp in _employees) 
            {
                Console.WriteLine(emp.ToString);
            }
        }
        void GetAllEmployeesBySalary(int salary)
        {
            foreach (Employee emp in _employees)
            {
                if (emp.Salary == salary) 
                { 
                    Console.WriteLine(emp.ToString);
                }
            }
        }
        void GetAllEmployeesByDepartmentNo(int departmentNo) 
        {
            foreach (Employee emp in _employees)
            {
                if (emp.DepartmentNo == departmentNo )
                {
                    Console.WriteLine(emp.ToString);
                }
            }
        }








    }
}
