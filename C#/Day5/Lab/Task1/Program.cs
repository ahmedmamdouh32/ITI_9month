namespace Task1
{
    internal class Program
    {

        public class WrongDayException : Exception
        {
            public int _day { set; get; }
            public WrongDayException(int user_input_day) : base("Invalid Day Value")
            {
                _day = user_input_day;
            }
        }
        public class WrongMonthException : Exception
        {
            public int _month { set; get; }
            public WrongMonthException(int user_input_month) : base("Invalid Month Value")
            {
                _month = user_input_month;
            }
        }
        public class WrongYearException : Exception
        {
            public int _year { set; get; }
            public WrongYearException(int user_input_year) : base("Invalid Year Value")
            {
                _year = user_input_year;
            }
        }
        public class WrongEmployeeIdException : Exception
        {
            public int _id { set; get; }
            public WrongEmployeeIdException(int id) : base("Invalid Employee ID Value")
            {
                _id = id;
            }
        }

        public class WrongEmployeeSalaryException : Exception
        {
            public decimal _salary { set; get; }
            public WrongEmployeeSalaryException(decimal salary) : base("Invalid Employee Salary Value")
            {
                _salary = salary;
            }
        }


        struct Date
        {
            int _day;
            int _month;
            int _year;

            public int day
            {
                set
                {
                    if (value < 1 || value > 31) throw new WrongDayException(value);
                    else _day = value;
                }
                get { return _day; }
            }
            public int month
            {
                set
                {
                    if (value < 1 || value > 12) throw new WrongMonthException(value);
                    else _month = value;
                }
                get { return _month; }
            }
            public int year
            {
                set
                {
                    if (value < 0) throw new WrongYearException(value);
                    else _year = value;
                }
                get { return _year; }
            }

            public Date(int Day, int Month, int Year)
            {
                _day = Day;
                _month = Month;
                _year = Year;
            }

            public override string ToString()
            {
                return $"{month}/{day}/{year}";
            }

            public static bool operator <(Date a, Date b)
            {
                if (a.year >= b.year) return true;
                else if (a.month >= b.month) return true;
                else if (a.day >= b.day) return true;
                else return false;
            }
            public static bool operator >(Date a, Date b)
            {
                //to be created
                return true;
            }
        }
        struct Employee
        {
            int _id;
            decimal _salary;
            Date _hireDate;
            public Employee(int ID, decimal Salary, Date HireDate)
            {
                _id = ID;
                _salary = Salary;
                _hireDate = HireDate;
            }
            public int id
            {
                set
                {
                    if (value < 0) throw new WrongEmployeeIdException(value);
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
                    if (value < 0) throw new WrongEmployeeSalaryException(value);
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

            public override string ToString()
            {
                return $"ID : {_id}, Salary : {String.Format("{0:C}", _salary)}, Hire Date : {_hireDate.ToString()}";
            }
        }

        static void Main(string[] args)
        {
            string filePath = @"C:\Users\adminstrator\Documents\ITI_9Months\C#\Day5\Lab\Task1\logs.txt";
            string exceptionMessage;


            Date d1 = new Date(Day: 2, Month: 5, Year: 2002);
            Date d2 = new Date(Day: 1, Month: 5, Year: 2002);
            Console.WriteLine(d1 < d2);

            Employee[] employees = new Employee[5]
            {
                new Employee(ID:1,Salary:12000,HireDate:new Date(1,1,2002)),
                new Employee(ID:2,Salary:2000,HireDate:new Date(4,5,2002)),
                new Employee(ID:3,Salary:13000,HireDate:new Date(2,2,2003)),
                new Employee(ID:4,Salary:14000,HireDate:new Date(1,2,2004)),
                new Employee(ID:5,Salary:11000,HireDate:new Date(3,1,2005))
            };

            //------------------------Sorting Employees-----------------
            for (int i = 1; i < employees.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (employees[j + 1].hireDate < employees[j].hireDate)
                    {
                        Employee temp = employees[j];
                        employees[j] = employees[j + 1];
                        employees[j + 1] = temp;
                    }
                    else break;
                }
            }

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }

            Date date = new Date();
            Employee employee = new Employee();


            try
            {
                Console.WriteLine("Enter Hire Date Day");
                date.day = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Hire Date Month");
                date.month = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Hire Date Year");
                date.year = int.Parse(Console.ReadLine());

                employee.hireDate = date;
                Console.WriteLine("Enter Employee ID :");
                employee.id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Salary :");
                employee.salary = decimal.Parse(Console.ReadLine());

            }
            catch (WrongDayException ex)
            {
                exceptionMessage = $"{DateTime.Now}, Message : {ex.Message} : {ex._day}, Source : {ex.Source}";
                Console.WriteLine(exceptionMessage);
                File.writeToFile(filePath, exceptionMessage);
            }
            catch (WrongMonthException ex)
            {
                exceptionMessage = $"{DateTime.Now}, Message : {ex.Message} : {ex._month}, Source : {ex.Source}";
                Console.WriteLine(exceptionMessage);
                File.writeToFile(filePath, exceptionMessage);
            }
            catch (WrongYearException ex)
            {
                exceptionMessage = $"{DateTime.Now}, Message : {ex.Message} : {ex._year}, Source : {ex.Source}";
                Console.WriteLine(exceptionMessage);
                File.writeToFile(filePath, exceptionMessage);
            }
            catch (WrongEmployeeIdException ex)
            {
                exceptionMessage = $"{DateTime.Now}, Message : {ex.Message} : {ex._id}, Source : {ex.Source}";
                Console.WriteLine(exceptionMessage);
                File.writeToFile(filePath, exceptionMessage);
            }
            catch (WrongEmployeeSalaryException ex)
            {
                exceptionMessage = $"{DateTime.Now}, Message : {ex.Message} : {ex._salary}, Source : {ex.Source}";
                Console.WriteLine(exceptionMessage);
                File.writeToFile(filePath, exceptionMessage);
            }
            catch (Exception ex)
            {
                exceptionMessage = ex.Message;
                Console.WriteLine(exceptionMessage);
                File.writeToFile(filePath, exceptionMessage);
            }



            //employee.hireDate.day = 33;

        }
        public class File
        {
            static public void writeToFile(string filePath, string text)
            {
                System.IO.File.AppendAllText(filePath, $"{text}\n");
            }
        }


    }
}
