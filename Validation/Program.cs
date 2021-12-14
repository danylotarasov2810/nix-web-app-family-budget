using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using DL.Models;

namespace Validation // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();

           Console.WriteLine("Введите родство");
            string relationdegree = Console.ReadLine();

            Console.WriteLine("Введите количество полных лет");
            int years = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите email");
            string email = Console.ReadLine();

            Console.WriteLine("Введите номер телефона");
            string phone = Console.ReadLine();

            Users user = new Users
            {
                Name = name,
                Surname = surname,
                Relationdegree = relationdegree,
                Years = years,
                Email = email,
                Phone = phone

            }


            var results = new List<ValidationResult>();
            var context = new ValidationContext(user);
            if (!Validator.TryValidateObject(user, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            Console.Read();
        }
    }
}
