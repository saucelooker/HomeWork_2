using System;
namespace HomeWork_5
{
    public class Person
    {

        public Person()
        {
        }
        public string _fullName { get; set; }
        public string _position { get; set; }
        public string _email { get; set; }
        public string _phoneNumber { get; set; }
        public int _salary { get; set; }
        public int _age { get; set; }

        public Person(string fullName,string position,string email,string phoneNumber,int salary,int age )
        {
            _fullName = fullName;
            _position = position;
            _email = email;
            _phoneNumber = phoneNumber;
            _salary = salary;
            _age = age;
        }
        public void PrintPerson()
        {
            Console.Write($"{_fullName} ");
            Console.Write($"{_position} ");
            Console.Write($"{_email} ");
            Console.Write($"{_phoneNumber} ");
            Console.Write($"{_salary} ");
            Console.WriteLine(_age);
        }
    }
}
