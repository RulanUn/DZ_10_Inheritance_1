using System;

namespace Inheritance_1
{
    abstract class Animal
    {
        private string kinde;
        private string nickname;
        public string Kinde
        {
            get { return kinde; }
            set { kinde = value; }
        }
        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }
        public void PrintKinde()
        {
            Console.WriteLine(Kinde);
        }
        public void PrintNickname()
        {
            Console.WriteLine(Nickname);
        }
    }
    class Horse : Animal
    {
        public void PrintHorse()
        {
            Console.WriteLine("Класс Лошадей");
        }
    }
    class Turtle : Animal
    {
        public void PrintTurtle()
        {
            Console.WriteLine("Класс Черепах");
        }
    }
    abstract class Human
    {
        private string name;
        private string profession;
        private int salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public void PrintName()
        {
            Console.WriteLine(Name);
        }
        public void PrintProfession()
        {
            Console.WriteLine(Profession);
        }
        public void PrintSalary()
        {
            Console.WriteLine(Salary);
        }
    }
    class Policeman : Human
    {
        public void PrintPoliceman()
        {
            Console.WriteLine("Класс Полицейские");
        }
    }
    abstract class Doctor : Human
    {
        public void PrintDoctor()
        {
            Console.WriteLine("Класс Доктора");
        }
    }
    class Dentist : Doctor
    {
        public void PrintDentist()
        {
            Console.WriteLine("Класс Доктора");
        }
    }
    class Oculist : Doctor
    {
        public void PrintOculist()
        {
            Console.WriteLine("Класс Окулисты");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Horse horse = new Horse();
            horse.Kinde = "Проживальского";
            horse.Nickname = "Друг";
            horse.PrintHorse();
            Console.WriteLine($"Парода лошади - {horse.Kinde};\nПрозвище лошади - {horse.Nickname}");
            Console.WriteLine("===============");
            Turtle turtle = new Turtle();
            turtle.PrintTurtle();
            Console.WriteLine("===============");
            Policeman policeman = new Policeman();
            policeman.Name = "Федор";
            policeman.Salary = 300000;
            policeman.PrintPoliceman();
            Console.WriteLine($"Имя полицейского -  {policeman.Name};\nЗароботная плата полицейского - {policeman.Salary}");
            Console.WriteLine("===============");
            Dentist dentist = new Dentist();
            dentist.PrintDentist();
            Console.WriteLine("===============");
            Oculist oculist = new Oculist();
            oculist.PrintOculist();

            Console.ReadKey();
        }
    }
}
