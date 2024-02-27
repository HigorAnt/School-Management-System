using System;
using SchoolManagementSystem.entities.enums;

namespace SchoolManagementSystem.entities
{
    sealed class Student : Person
    {
        public int Matriculation {  get; set; } 
        public int Series { get; set; }
        public EducationalDivision Degree { get; set; }
        public Student(string name, ulong cpf, string dateOfBirth, int matricula, int series, EducationalDivision degree) : base(name, cpf, dateOfBirth)
        {
            Matriculation = matricula;
            Series = series;
            Degree = degree;
        }
        public sealed override void printPerson()
        { 
            base.printPerson();
            Console.WriteLine("Matrícula: " + Matriculation);
            Console.WriteLine("Série: " + Series);
            Console.WriteLine("Grau educacional: " + Degree.ToString());
        }
    }
}
