using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9_17october
{
    public class Employee
    {
        static int ID;

        int _id=ID;
        string _name;
        string _surname;
        byte _age;
        int _departmentNo;
        int _salary;

        public Employee(string name, string surname, byte age, int departmentNo, int salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentNo = departmentNo;
            Salary = salary;
            ID++;
        }

        public int Id
        {
            get { return _id; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public byte Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public int DepartmentNo
        {
            get { return _departmentNo; }
            set { _departmentNo = value; }
        }
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }



    }
}
