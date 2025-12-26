namespace Task2
{
    internal class Program
    {
        struct Date
        {
            int _day;
            int _month;
            int _year;

            public int day
            {
                set
                {
                    if (value < 1 || value > 31) throw new Exception();
                    else _day = value;
                }
                get { return _day; }
            }
            public int month
            {
                set
                {
                    if (value < 1 || value > 12) throw new Exception();
                    else _month = value;
                }
                get { return _month; }
            }
            public int year
            {
                set
                {
                    if (value < 0) throw new Exception();
                    else _year = value;
                }
                get { return _year; }
            }

            public string getDate()
            {
                return $"{month}/{day}/{year}";
            }
        }
        struct Employee
        {
            int _id;
            decimal _salary;
            Date _hireDate;
            public int id
            {
                set
                {
                    if (value < 0) throw new Exception();
                    else _id = value;
                }
                get
                {
                    return _id;
                }
            }
            public decimal salary
            {
                set
                {
                    if (value < 0) throw new Exception();
                    else _salary = value;
                }
                get { return _salary; }
            }
            public Date hireDate
            {
                set
                {
                    _hireDate = value;
                }
                get { return _hireDate; }
            }

            public string getEmployee()
            {
                return $"ID : {id}, Salary : {salary}, Hire Date : {hireDate.getDate()}";
            }
            
        }
        static void Main(string[] args)
        {

            Console.WriteLine("How many Employees Do you have ?");
            int EmployeesCounter = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[EmployeesCounter];

            for (int employeeIndex=0; employeeIndex < EmployeesCounter; employeeIndex++)
            {
                Console.WriteLine($"Enter Data of employee NO.{employeeIndex+1}");
                Console.WriteLine("Employee ID :");
                employees[employeeIndex].id = int.Parse(Console.ReadLine());
                Console.WriteLine("Employee Salary :");
                employees[employeeIndex].salary = decimal.Parse(Console.ReadLine());
                Date employeeDate = new Date();
                Console.WriteLine("Employee Date (Day) :");
                employeeDate.day = int.Parse(Console.ReadLine());
                Console.WriteLine("Employee Date (Month) :");
                employeeDate.month = int.Parse(Console.ReadLine());
                Console.WriteLine("Employee Date (Year) :");
                employeeDate.year = int.Parse(Console.ReadLine());
                employees[employeeIndex].hireDate = employeeDate;
            }


            for(int i = 0; i < EmployeesCounter; i++)
            {
                Console.WriteLine(employees[i].getEmployee());

            }

        }
    }
}
