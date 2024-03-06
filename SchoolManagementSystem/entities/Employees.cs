using System;
using System.Collections.Generic;
using SchoolManagementSystem.entities.enums;

namespace SchoolManagementSystem.entities
{
    class Employees : Person
    {
        private double salary;
        private int workload;
        public AcademicEducation AcademicEducationLevel { get; set; }
        public Employees() { }
        public Employees(string name, ulong cpf, string dateOfBirth, double salary, int workload, AcademicEducation academicEducation) : base(name, cpf, dateOfBirth)
        {
            this.setSalary(salary);
            this.setWorkload(workload);
            AcademicEducationLevel = academicEducation;
        }
        public void setSalary(double salary)
        {
            this.salary = salary;
        }
        public double getSalary()
        {
            return salary;
        }
        public void setWorkload(int  workload)
        {
            this.workload = workload;
        }
        public int getWorkload()
        {
            return workload;
        }
        public double valueSalary()
        {
            return getSalary() * getWorkload();
        }
        public override void printPerson()
        {
            base.printPerson();
            Console.WriteLine("Salário: " + valueSalary());
        }
    }
}