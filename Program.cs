namespace polymorphism
{
    //      BANK INTERSET 
    class BankAccount
    {
        public BankAccount(double balance)
        {
            if (balance >= 0)
                this.Balance = balance;
        }
        public double Balance { get; set; }
        public virtual double CalculateInterset()
        {
            return Balance; 
        }
    }
    class SavingAccount : BankAccount
    {
        public SavingAccount(double balance) : base(balance)
        {

        }

        public override double CalculateInterset()
        {
            return Balance += Balance / 100 * 5;
        }
    }
   class CurrentAccount : BankAccount
    {
        public CurrentAccount (double balance) : base(balance)
        {

        }
        public override double CalculateInterset()
        {
            return Balance += Balance / 100 * 2;
        }

    }


    //          EMPLOYEE MANAGEMENT  
    class Employee
    {

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; }
        public double Salary { get; set; }
        public virtual double CalculateSalary()
        {
            return Salary; 
        }
        public virtual double Bounes()
        {
            return 0;
        }

    }
    class Manager : Employee
    {
        public Manager(string name, double salary) : base(name, salary)
        {
        }

        public override double CalculateSalary()
        {
            return Salary + Bounes();
        }
        public override double Bounes()
        {
            return Salary / 100 * 20;
        }
    }
    class Developer : Employee
    {
        public Developer(string name, double salary) : base(name, salary)
        {
        }

        public override double CalculateSalary()
        {
            return Salary + Bounes();
        }
        public override double Bounes()
        {
            return Salary / 100 * 20;
        }
    }
    class Intern : Employee
    {
        public Intern(string name, double salary) : base(name, salary)
        {
        }

        public override double CalculateSalary()
        {
            return Salary + Bounes();
        }
        public override double Bounes()
        {
            return Salary / 100 * 20;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {           
            List<Employee> employees = new List<Employee>();
            employees.Add(new Manager("bahaa", 20000));
            employees.Add(new Developer("mona", 10000));
            employees.Add(new Intern("waleed", 2000));
            foreach (Employee emp in employees)
            {
                Console.WriteLine("name : " + emp.Name);
                Console.WriteLine("type : " + emp.GetType().Name);
                Console.WriteLine("salary : " + emp.Salary);
                Console.WriteLine("bonus : " + emp.Bounes());
                Console.WriteLine("salary with bonus : " + emp.CalculateSalary());
                Console.WriteLine("-------------------------------------");
            }
        }
    }
}
