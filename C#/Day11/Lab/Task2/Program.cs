using System.Text;

namespace Task2
{
    internal class Program
    {
        public enum LayoffCause
        {
            Performance,
            FinancialIssues,
            ContractEnd,
            AgeLimit,
            VacationsLimit
        }
        public class EmployeeLayOffEventArgs
        {
            public EmployeeLayOffEventArgs(LayoffCause cause)
            {
                Cause = cause;
            }
            public LayoffCause Cause { get; set; }
        }

        class Employee
        {
            public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
            public event EventHandler EmployeeAdding;


            public Employee(int ID, DateTime BirthDate,int Vacation)
            {
                EmployeeID = ID;
                _BirthDate = BirthDate;
                _VacationStock = Vacation;
                EmployeeAdding?.Invoke(this, EventArgs.Empty);
            }

            protected virtual void OnEmployeeLayOff (EmployeeLayOffEventArgs e)
            {
                EmployeeLayOff?.Invoke (this, e);
            }

            protected virtual void OnEmployeeLayAdding(EventArgs e)
            {
                EmployeeAdding?.Invoke(this,e);
            }

            const int VacationStockLimit = 12;

            public int EmployeeID { get; set; }

            DateTime _BirthDate;
            int _VacationStock;
            public DateTime BirthDate
            {
                get
                {
                    return _BirthDate;
                }
                set {
                    if (DateTime.Now.Year - BirthDate.Year >= 60)
                    {
                        throw new Exception("Year limits exceeds");
                    }
                    else
                    {
                        _BirthDate = value;
                    }
                }
            }

            public int VacationStock
            {
                //assume the limit is 10
                get
                {
                    return _VacationStock;
                }
                set
                {
                    if(value > VacationStockLimit)
                    {
                        throw new Exception("VAcation Stock Limit value");
                    }
                    else
                    {
                        VacationStock = value;
                    }
                }
            }

            public bool RequestVacation(DateTime From, DateTime To)
            {
                //assume vacation more than 3 days will be rejected
                if ((To - From).Days >= 3)
                    return false;
                else
                {
                    if(--_VacationStock < 0)
                    {
                        OnEmployeeLayOff(new EmployeeLayOffEventArgs(LayoffCause.VacationsLimit));
                    }
                    return true;
                }
            }

            public void EndOfYearOperation() //checks if there are employees have age more than 60
            {
                if(DateTime.Now.Year - BirthDate.Year >= 60)
                {
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs(LayoffCause.AgeLimit));
                }
                throw new NotImplementedException();
            }
            public override string ToString() => $"ID:{EmployeeID}, Birth Date:{_BirthDate},Vacation Stock{_VacationStock}";
        }
        class Department
        {
            public int DeptID { get; set; }
            public string DeptName { get; set; }

            List<Employee> Staff;

            public Department(int id, string name, List<Employee> employees)
            {
                DeptID = id;
                DeptName = name;
                Staff = employees;
            }
            public void AddStaff(Employee E)
            {
                Staff.Append(E);
            }
            ///CallBackMethod 
            public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
            {
                if(e.Cause == LayoffCause.AgeLimit || e.Cause == LayoffCause.VacationsLimit)
                {
                    Staff.Remove((Employee)sender);
                }
            }
            public override string ToString()
            {
                StringBuilder result = new StringBuilder();
                if (Staff != null)
                {
                    foreach (var member in Staff)
                    {
                        result.AppendLine(member.ToString());
                    }
                }
                else
                {
                    result.Append("Club is empty");
                }
                return result.ToString();
            }
        }

        class Club
        {
            public int ClubID { get; set; }
            public String ClubName { get; set; }

            List<Employee> Members;

            public Club(int id, string Name, List<Employee> members)
            {
                ClubID = id;
                ClubName = Name;
                Members = members;
            }
            public void AddMember(Employee E)
            {
                Members.Append(E);
            }
            ///CallBackMethod 
            public void RemoveMember(object sender, EmployeeLayOffEventArgs e) 
            { 
                if(e.Cause == LayoffCause.VacationsLimit)
                {
                    Members.Remove((Employee)sender);
                }
            }


            public override string ToString()
            {
                StringBuilder result = new StringBuilder();
                if (Members != null)
                {
                    foreach (var member in Members)
                    {
                        result.AppendLine(member.ToString());
                    }
                }
                else
                {
                    result.Append("Club is empty");
                }
                return result.ToString();
            }
        }
        static void Main(string[] args)
        {

            List<Employee> people = new List<Employee>
            {
                new Employee(1,new DateTime(2002,1,1),5),
                new Employee(2,new DateTime(2002,1,1),5),
                new Employee(3,new DateTime(2002,1,1),5),
                new Employee(4,new DateTime(2002,1,1),5)
            };

            Club club = new Club(1, "Benha Club", people);
            Department department = new Department(1, "IT", people);

            foreach (var emp in people)
            {
                emp.EmployeeLayOff += club.RemoveMember;
                emp.EmployeeLayOff += department.RemoveStaff;
            }
            people[0].RequestVacation(new DateTime(2026, 1, 1), new DateTime(2026, 1, 3));
            people[0].RequestVacation(new DateTime(2026, 1, 1), new DateTime(2026, 1, 3));
            people[0].RequestVacation(new DateTime(2026, 1, 1), new DateTime(2026, 1, 3));
            people[0].RequestVacation(new DateTime(2026, 1, 1), new DateTime(2026, 1, 3));
            people[0].RequestVacation(new DateTime(2026, 1, 1), new DateTime(2026, 1, 3));
            people[0].RequestVacation(new DateTime(2026, 1, 1), new DateTime(2026, 1, 3));

            Console.WriteLine("People in Club :");
            Console.WriteLine(club);

            Console.WriteLine("People in Department");
            Console.WriteLine(department);
            
           

                
            



           
        }
    }
}
