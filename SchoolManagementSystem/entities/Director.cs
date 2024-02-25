using SchoolManagementSystem.entities.enums;
using System;

namespace SchoolManagementSystem.entities
{
    sealed class Director : Employees
    {
        private string Email {  get; set; }
        private string password;
        public Director(string name, ulong cpf, string dateOfBirth, double salary, int workload, AcademicEducation academicEducation, string email) : base(name, cpf, dateOfBirth, salary, workload, academicEducation) 
        {
            Email = email;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getPassword()
        {
            return password;
        }
        public sealed override void printPerson()
        {
            base.printPerson();
        }
    }
}
