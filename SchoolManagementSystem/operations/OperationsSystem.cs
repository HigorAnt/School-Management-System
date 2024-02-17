using System;

namespace SchoolManagementSystem.operations
{
    class OperationsSystem
    {
        private string password;
        public void generatePassword(int tamanho)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(Enumerable.Repeat(chars, tamanho).Select(s => s[random.Next(s.Length)]).ToArray());
            password = result;
        }
        public void setPassword(string newPassword)
        {
            password = newPassword;
        }
        public string getPassword()
        {
            return password;
        }
        public void updatePassword(string atualyPassword)
        {
            if(atualyPassword == getPassword())
            {
                string newPassword = Console.ReadLine();
                setPassword(newPassword);
            }
        }
    }
}
