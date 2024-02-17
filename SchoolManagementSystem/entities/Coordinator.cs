using SchoolManagementSystem.entities.enums;
using System;

namespace SchoolManagementSystem.entities
{
    sealed class Coordinator : Employees
    {
        List<Coordinator> coordinators = new List<Coordinator>();
        public string OccupationArea { get; set; }
        public Coordinator(string name, ulong cpf, string dateOfBitth, double salary, int workload, AcademicEducation academicEducation, string occupationArea) : base(name, cpf, dateOfBitth, salary, workload, academicEducation)
        {
            OccupationArea = occupationArea;
        }
        public void setCoordinator(Coordinator coordinator)
        {
            coordinators.Add(coordinator);
        }
        public sealed override void printPerson()
        {
            base.printPerson();
            Console.WriteLine("Área de ocupação: " + OccupationArea);
        }
    }
}
