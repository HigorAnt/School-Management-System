using SchoolManagementSystem.entities.enums;
using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.entities
{
    sealed class Teacher : Employees
    {
        private List<Teacher> teachers = new List<Teacher>();
        private List<string> disciplines = new List<string>();
        public Teacher(string name, ulong cpf, string dateOfBirth, double salary, int workload, AcademicEducation academicEducation, List<string> disciplines) : base(name, cpf, dateOfBirth, salary, workload, academicEducation)
        { 
            this.disciplines = disciplines;
        }
        public sealed override void printPerson()
        {
            base.printPerson();
            Console.Write("Disciplinas ministradas: ");
            for(int i=1; i<=disciplines.Count; i++)
            {
                Console.Write(disciplines[i]);
                if (i < disciplines.Count)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
