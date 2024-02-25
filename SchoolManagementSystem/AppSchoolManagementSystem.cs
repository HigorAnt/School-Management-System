using SchoolManagementSystem.entities;
using SchoolManagementSystem.entities.enums;
using SchoolManagementSystem.operations;
using System.Collections.Generic;
using System;

namespace SchoolManagementSystem
{
    public class AppSchoolManagementSystem
    {
        static void Main(string[] args)
        {
            List<string> disciplines = new List<string>();
            OperationsSystem operation = new OperationsSystem();
            Director director;
            Coordinator coordinator;
            Teacher teacher;
            Student student;

            operation.setPassword("admin");

            string password = "", name, dateOfBirth, email, ocupationArea;
            double salary;
            int oper, workLoad, matricula, series;
            ulong cpf;
            AcademicEducation formation;
            EducationalDivision degree;

            Console.WriteLine("Welcome to School Management System!");
            Console.WriteLine("What is the system access password?");

            while(operation.validationPassword(password) == false)
            {
                password = Console.ReadLine();
                if(operation.validationPassword(password) == false)
                {
                    Console.WriteLine("invalid Password!");
                }
            }

            Console.WriteLine("Which operation do you want to perform?");
            oper = int.Parse(Console.ReadLine());

            if((oper == 0) || (oper == 1) || (oper ==2))
            {
                Console.WriteLine("Complete the following informations:");
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("CPF: ");
                cpf = ulong.Parse(Console.ReadLine());
                Console.Write("What is the date of birth?");
                dateOfBirth = Console.ReadLine();
                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine());
                Console.Write("Workload:");
                workLoad = int.Parse(Console.ReadLine());
                Console.WriteLine("Formation: ");
                formation = Enum.Parse<AcademicEducation>(Console.ReadLine());

                switch (oper)
                {
                    case 0:
                        Console.WriteLine("E-mail: ");
                        email = Console.ReadLine();
                        director = new Director(name, cpf, dateOfBirth, salary, workLoad, formation, email);
                        break;
                    case 1:
                        Console.WriteLine("Ocuppation area:");
                        ocupationArea = Console.ReadLine();
                        coordinator = new Coordinator(name, cpf, dateOfBirth, salary, workLoad, formation, ocupationArea);
                        break;
                    case 2:
                        Console.WriteLine("Disciplines: ");
                        int qntd = int.Parse(Console.ReadLine());
                        for(int i = 0; i<qntd; i++)
                        {
                            disciplines.Add(Console.ReadLine());
                        }
                        teacher = new Teacher(name, cpf, dateOfBirth, salary, workLoad, formation, disciplines);
                        break;
                    default:
                        break;
                }
            }
            if(oper == 3)
            {
                Console.WriteLine("Complete the following informations:");
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("CPF: ");
                cpf = ulong.Parse(Console.ReadLine());
                Console.Write("What is the date of birth?");
                dateOfBirth = Console.ReadLine();
                Console.Write("Matricula: ");
                matricula = int.Parse(Console.ReadLine());
                Console.WriteLine("Series: ");
                series = int.Parse(Console.ReadLine());
                Console.Write("Degree educational: ");
                degree = Enum.Parse<EducationalDivision>(Console.ReadLine());

                student = new Student(name, cpf, dateOfBirth, matricula, series, degree);
            }
        }
    }
}