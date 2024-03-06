using SchoolManagementSystem.entities.enums;
using System;

namespace SchoolManagementSystem.entities
{
    sealed class Coordinator : Employees 
    {
        public string OccupationArea { get; set; }
        public Coordinator(string name, ulong cpf, string dateOfBirth, double salary, int workload, AcademicEducation academicEducation, string occupationArea) : base(name, cpf, dateOfBirth, salary, workload, academicEducation)
        {
            OccupationArea = occupationArea;
        }
        public sealed override void printPerson()
        {
            base.printPerson();
            Console.WriteLine("Área de ocupação: " + OccupationArea);
        }
    }
}
