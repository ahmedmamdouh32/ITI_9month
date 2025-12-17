#include <iostream>

using namespace std;


class Employee{
    string name;
    int salary;
    int id;
public:
    Employee* pNext;
    Employee* pPrevious;
    Employee(){
        name = "";
        salary = 0;
        id = 0;
    }
    Employee(string name, int id, int salary){
        this->name = name;
        this->id = id;
        this->salary = salary;
    }
    int getCode(){return id;}
    string getName(){return name;}
    void printEmployee(){cout<<"Name : "<<name<<", ID : "<<id<<", Salary : "<<salary<<endl;}
};

/* ------Bonus task (not completed)----------
void swapObjects(Employee* emp1, Employee* emp2){
    Employee* temp = emp1;
    emp1->pNext=emp2->pNext;
    emp1->pPrevious = emp2->pPrevious;
    emp2->pNext = temp->pNext;
    emp2->pPrevious = temp->pPrevious;
}
*/

class LinkedList{
    public :
        Employee* pStart;
        Employee* pEnd;
        LinkedList(){
            pStart = pEnd = NULL;
        }
    void insertNode(Employee* pItem){
        if(pStart == NULL){
            pStart = pEnd = pItem;
            pItem->pNext = NULL;
            pItem->pPrevious = NULL;
        }
        else{
            pItem->pPrevious = pEnd;
            pItem->pNext = NULL;
            pEnd->pNext = pItem;
            pEnd = pItem;
        }
    }
    Employee* searchNode(int id){
        Employee* pTemp = NULL;
        pTemp = pStart;
        while(pTemp != NULL && pTemp->getCode() != id){
            pTemp = pTemp->pNext;
        }
        return pTemp;
    }
    void displayAll(){
        if(pStart == NULL){
            cout<<"List is Empty"<<endl;
        }
        else{
            Employee* pTemp = pStart;
            while(pTemp != NULL){
                pTemp->printEmployee();
                pTemp = pTemp->pNext;
            }
        }
    }
    int deleteNode(int id){
        if(pStart == NULL){
            cout<<"List is empty"<<endl;
            return 0;
        }
        Employee* pTemp = searchNode(id);
        if(pTemp == NULL){
            cout<<"Node not found"<<endl;
            return -1;
        }
        else{
            if(pStart == pEnd){
                pStart = pEnd = NULL;
            }
            else if(pTemp == pStart){ //the first node
                pStart = pStart->pNext;
                pStart->pPrevious=NULL;

            }
            else if(pTemp == pEnd){ //the last node
                pEnd = pEnd->pPrevious;
                pEnd->pNext=NULL;
            }
            else{ //node in the middle
                pTemp->pPrevious->pNext = pTemp->pNext;
                pTemp->pNext->pPrevious = pTemp->pPrevious;
            }
            delete pTemp;
            return 1; //deleting done successfully
        }
    }
    void deleteList(){
        Employee* pTemp;
        while(pStart != NULL){
            pTemp = pStart;
            pStart = pStart->pNext;
            delete pTemp;
        }
        pEnd = NULL;
    }
    void insertFirst(Employee* pItem){
        if(pStart == NULL){ //list is empty
            insertNode(pItem);
        }
        else{
            pStart->pPrevious = pItem;
            pItem->pPrevious=NULL;
            pItem->pNext=pStart;
            pStart = pItem;
        }
    }

    void insertByIndex(Employee* pItem,int index){
        if(pStart == NULL){ //list is empty
            insertNode(pItem);
        }
        else if(index == 0){
            insertFirst(pItem);
        }
        else{
            Employee* pTemp = pStart;
            for(int i=1;i<index;i++){
              if(pTemp->pNext == pEnd){
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


int main()
{

    Employee* emp1 = new Employee("ahmed",1,4000);
    Employee* emp2 = new Employee("ashraf",2,5000);
    Employee* emp3 = new Employee("sara",3,5500);
    Employee* emp4 = new Employee("mariam",4,600);
    Employee* emp5 = new Employee("tarek",5,3000);

    LinkedList linkedlist;

    linkedlist.insertNode(emp1);
    linkedlist.insertNode(emp2);
    linkedlist.insertNode(emp3);
    linkedlist.insertNode(emp4);
    linkedlist.insertNode(emp5);

    //linkedlist.deleteList();

    linkedlist.displayAll();

    linkedlist.deleteNode(1);
    linkedlist.displayAll();

    linkedlist.deleteNode(2);
    linkedlist.displayAll();

    linkedlist.deleteNode(3);
    linkedlist.displayAll();

    linkedlist.deleteNode(4);
    linkedlist.displayAll();

    linkedlist.deleteNode(5);
    linkedlist.displayAll();

    Employee* emp6 = new Employee("tarek",6,3000);
    Employee* emp7 = new Employee("ahmed",7,3000);

    Employee* emp8 = new Employee("ayman",8,3000);
    Employee* emp9 = new Employee("fady",9,3000);

    linkedlist.insertNode(emp6);
    linkedlist.displayAll();
    cout<<"------------------"<<endl;
    linkedlist.insertFirst(emp7);
    linkedlist.displayAll();

    cout<<"------------------"<<endl;

    linkedlist.insertByIndex(emp8,1);
    linkedlist.displayAll();
    cout<<"------------------"<<endl;
    linkedlist.insertByIndex(emp9,3);
    linkedlist.displayAll();


    cout<<"-----------------"<<endl;

    swapObjects(emp6,emp9);
    linkedlist.displayAll();

    return 0;
}
