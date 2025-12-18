#include <iostream>

using namespace std;


class Employee {
    string name;
    int salary;
    int id;
public:
    Employee* pNext;
    Employee* pPrevious;
    Employee() {
        name = "";
        salary = 0;
        id = 0;
    }
    Employee(string name, int id, int salary) {
        this->name = name;
        this->id = id;
        this->salary = salary;
    }
    int getCode() { return id; }
    string getName() { return name; }
    void printEmployee() { cout << "Name : " << name << ", ID : " << id << ", Salary : " << salary << endl; }
};

class LinkedList {
public:
    Employee* pStart;
    Employee* pEnd;
    LinkedList() {
        pStart = pEnd = NULL;
    }
    void insertNode(Employee* pItem) {
        if (pStart == NULL) {
            pStart = pEnd = pItem;
            pItem->pNext = NULL;
            pItem->pPrevious = NULL;
        }
        else {
            pItem->pPrevious = pEnd;
            pItem->pNext = NULL;
            pEnd->pNext = pItem;
            pEnd = pItem;
        }
    }
    Employee* searchNode(int id) {
        Employee* pTemp = NULL;
        pTemp = pStart;
        while (pTemp != NULL && pTemp->getCode() != id) {
            pTemp = pTemp->pNext;
        }
        return pTemp;
    }
    void displayAll() {
        if (pStart == NULL) {
            cout << "List is Empty" << endl;
        }
        else {
            Employee* pTemp = pStart;
            while (pTemp != NULL) {
                pTemp->printEmployee();
                pTemp = pTemp->pNext;
            }
        }
    }
    int deleteNode(int id) {
        if (pStart == NULL) {
            cout << "List is empty" << endl;
            return 0;
        }
        Employee* pTemp = searchNode(id);
        if (pTemp == NULL) {
            cout << "Node not found" << endl;
            return -1;
        }
        else {
            if (pStart == pEnd) {
                pStart = pEnd = NULL;
            }
            else if (pTemp == pStart) { //the first node
                pStart = pStart->pNext;
                pStart->pPrevious = NULL;

            }
            else if (pTemp == pEnd) { //the last node
                pEnd = pEnd->pPrevious;
                pEnd->pNext = NULL;
            }
            else { //node in the middle
                pTemp->pPrevious->pNext = pTemp->pNext;
                pTemp->pNext->pPrevious = pTemp->pPrevious;
            }
            delete pTemp;
            return 1; //deleting done successfully
        }
    }
    void deleteList() {
        Employee* pTemp;
        while (pStart != NULL) {
            pTemp = pStart;
            pStart = pStart->pNext;
            delete pTemp;
        }
        pEnd = NULL;
    }
    void insertFirst(Employee* pItem) {
        if (pStart == NULL) { //list is empty
            insertNode(pItem);
        }
        else {
            pStart->pPrevious = pItem;
            pItem->pPrevious = NULL;
            pItem->pNext = pStart;
            pStart = pItem;
        }
    }

    void insertByIndex(Employee* pItem, int index) {
        if (pStart == NULL) { //list is empty
            insertNode(pItem);
        }
        else if (index == 0) {
            insertFirst(pItem);
        }
        else {
            Employee* pTemp = pStart;
            for (int i = 1;i < index;i++) {
                if (pTemp->pNext == pEnd) {
                    insertNode(pItem); //that means we reached the end of list but the user wants an index after it
                    return;            //so we will add that far element to the end of list normally
                }
                pTemp = pTemp->pNext;
            }
            pItem->pNext = pTemp->pNext;
            pItem->pPrevious = pTemp;
            pItem->pNext->pPrevious = pItem;
            pTemp->pNext = pItem;
        }
    }
};


class Stack :private LinkedList {
	
public:
    int currentNodes = 0;
    Stack() : LinkedList() {
	}


	void push(Employee* pItem) {
        insertNode(pItem);
		currentNodes++;
    };

    Employee* pop() {
        if (pStart == NULL) {
			cout << "Stack is empty" << endl;
			return NULL;
		}
		else {
			Employee* pTemp;
            if (pStart == pEnd) {
                pTemp = pStart;
				pTemp->pNext = NULL;
				pTemp->pPrevious = NULL;
                pStart = NULL;
				pEnd = NULL;
            }
            else {
				pTemp = pEnd;
				pEnd = pEnd->pPrevious;
				pEnd->pNext = NULL;
            }
			currentNodes--;
            return pTemp;
        }
    }
};


int main()
{
    Employee* emp1 = new Employee("ahmed", 1, 4000);
    Employee* emp2 = new Employee("ashraf", 2, 5000);
    Employee* emp3 = new Employee("sara", 3, 5500);
    Employee* emp4 = new Employee("mariam", 4, 600);
    Employee* emp5 = new Employee("tarek", 5, 3000);

    Stack stack;
	stack.push(emp1);
	stack.push(emp2);
	stack.push(emp3);
	stack.push(emp4);
	stack.push(emp5);

	int stackNodes = stack.currentNodes;

    for (int i = 0; i < stackNodes;i++) {
		stack.pop()->printEmployee();
    }

    return 0;
}
