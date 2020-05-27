using CRUDBlazor.Database;
using CRUDBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CRUDBlazor.Services
{
    public class EmployeeServices
    {
        private readonly AppDbContext _db;
        public EmployeeServices(AppDbContext _db)
        {
            this._db = _db;
        }
        //Get all employee
        public List<EmployeeInfo> GetEmployees()
        {
            var empList = _db.Employees.ToList();
            return empList;
        }
        //insert employee info
        public string Create(EmployeeInfo objEmployee)
        {
            _db.Employees.Add(objEmployee);
            _db.SaveChanges();
            return "Save Successfully";
        }
        //get employee by ID
        public EmployeeInfo GetEmployeeByID(int id)
        {
            EmployeeInfo employee = _db.Employees.FirstOrDefault(s => s.EmployeeID == id);
            return employee;
        }
        //Update Employee info 
        public string UpdateEmployee  (EmployeeInfo objEmployee )
        {
            _db.Employees.Update(objEmployee);
            _db.SaveChanges();
            return "Updated";
        }
        //Delete Employee 
        public string Delete (EmployeeInfo objEmployee)
        {
            _db.Remove(objEmployee);
            _db.SaveChanges();
            return "deleted";
        }

    }
}
