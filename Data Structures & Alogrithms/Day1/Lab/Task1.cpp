#include <iostream>
using namespace std;

class Employee {
public:
	string name;
	int id;
	int salary;

	Employee(string name,int id, int salary) {
		this->name = name;
		this->id = id;
		this->salary = salary;
	}
	void printEmployee() {
		cout << "Name: " << name << ", ID: " << id << ", Salary: " << salary << endl;
	}
};

void sortEmployees(Employee emps[], int n) {
	for (int i = 1; i < n;i++) {
		for (int j = i - 1; j >= 0; j--) {
			if (emps[j + 1].salary < emps[j].salary) {
				swap(emps[j + 1], emps[j]);
			}
			else break;
		}
	}
}

int main()
{
	Employee emp1("Ahmed", 1, 5000);
	Employee emp2("Sara", 2, 6000);
	Employee emp3("Omar", 3, 5500);

	Employee Employees[] = { emp1, emp2, emp3 };

	sortEmployees(Employees, sizeof(Employees) / sizeof(Employees[0]));

	for (int i = 0; i < 3; i++) Employees[i].printEmployee();

    return 0;
}