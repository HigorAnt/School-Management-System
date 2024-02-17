using System;

namespace SchoolManagementSystem.entities
{
    class Person
    {
        private string Name { get; set; }
        private ulong Cpf { get; set; }
        private string DateOfBirth { get; set; }
        public Person() { }
        public Person(string name, ulong cpf, string dateOfBitth)
        {
            Name = name;
            Cpf = cpf;
            DateOfBirth = dateOfBitth;
        }
        public virtual void printPerson()
        {
            Console.WriteLine("Nome: " + Name + "\nCPF: " + Cpf + "\nData de nascimento: " + DateOfBirth);
        }
    }
}
