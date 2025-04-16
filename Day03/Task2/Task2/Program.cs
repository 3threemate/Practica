using System;

namespace StaffHierarchy
{
    public class Employee
    {
        protected string name;
        protected int age;
        protected string department;

        public Employee()
        {
            name = String.Empty;
            age = 0;
            department = String.Empty;
            Input();
        }

        public void Input()
        {
            Console.WriteLine("Введите имя сотрудника:");
            name = Console.ReadLine();
            Console.WriteLine("Введите возраст сотрудника:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите отдел сотрудника:");
            department = Console.ReadLine();
        }

        public virtual string Output()
        {
            return $"Имя: {name}, Возраст: {age}, Отдел: {department}";
        }
    }

    public class Worker : Employee
    {
        private string position;
        private int experience;

        public Worker() : base()
        {
            position = String.Empty;
            experience = 0;
            InputWorker();
        }

        private void InputWorker()
        {
            Console.WriteLine("Введите должность рабочего:");
            position = Console.ReadLine();
            Console.WriteLine("Введите стаж работы (в годах):");
            experience = Convert.ToInt32(Console.ReadLine());
        }

        public override string Output()
        {
            return base.Output() + $", Должность: {position}, Стаж: {experience} лет";
        }
    }

    public class Engineer : Employee
    {
        private string specialty;

        public Engineer() : base()
        {
            specialty = String.Empty;
            InputEngineer();
        }

        private void InputEngineer()
        {
            Console.WriteLine("Введите специализацию инженера:");
            specialty = Console.ReadLine();
        }

        public override string Output()
        {
            return base.Output() + $", Специализация: {specialty}";
        }
    }

    public class HR : Employee
    {
        private int employeesManaged;

        public HR() : base()
        {
            employeesManaged = 0;
            InputHR();
        }

        private void InputHR()
        {
            Console.WriteLine("Введите количество сотрудников в подчинении:");
            employeesManaged = Convert.ToInt32(Console.ReadLine());
        }

        public override string Output()
        {
            return base.Output() + $", Сотрудников в подчинении: {employeesManaged}";
        }
    }

    public class Administration : Employee
    {
        private string responsibilityArea;

        public Administration() : base()
        {
            responsibilityArea = String.Empty;
            InputAdmin();
        }

        private void InputAdmin()
        {
            Console.WriteLine("Введите зону ответственности:");
            responsibilityArea = Console.ReadLine();
        }

        public override string Output()
        {
            return base.Output() + $", Зона ответственности: {responsibilityArea}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создание рабочего:");
            Worker worker = new Worker();
            Console.WriteLine(worker.Output());

            Console.WriteLine("\nСоздание инженера:");
            Engineer engineer = new Engineer();
            Console.WriteLine(engineer.Output());

            Console.WriteLine("\nСоздание сотрудника кадров:");
            HR hr = new HR();
            Console.WriteLine(hr.Output());

            Console.WriteLine("\nСоздание администратора:");
            Administration admin = new Administration();
            Console.WriteLine(admin.Output());
        }
    }
}
