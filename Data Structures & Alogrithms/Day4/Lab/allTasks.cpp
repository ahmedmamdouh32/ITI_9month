#include <iostream>
#include<algorithm>
using namespace std;

class Employee {
    string name;
    int salary;
    int id;
public:
    Employee* pRight;
    Employee* pLeft;
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

class BinaryTree {
private:
    int treeMaxHeight = 0;
    Employee* pParent;
    Employee* insert(Employee* pRoot, Employee* data) {
        if(pRoot == NULL){
            data->pRight = NULL;
            data->pLeft = NULL;
            return data;
        }
        else {
            if (data->getCode() <= pRoot->getCode()) {
                pRoot->pLeft = insert(pRoot->pLeft, data);
            }
            else {
                pRoot->pRight = insert(pRoot->pRight, data);
            }
            return pRoot;
        }
    }
    void inOrder(Employee* pRoot) {
        if (pRoot) {
            inOrder(pRoot->pLeft);
            pRoot->printEmployee();
            inOrder(pRoot->pRight);
        }
    }
    void preOrder(Employee* pRoot)
    {
        if (pRoot) {
            pRoot->printEmployee();
            preOrder(pRoot->pLeft);
            preOrder(pRoot->pRight);
        }
    }
    void postOrder(Employee* pRoot) {
        if (pRoot) {
            preOrder(pRoot->pLeft);
            preOrder(pRoot->pRight);
            pRoot->printEmployee();
        }
    }
    Employee* findMin(Employee* pRoot) {
        while (pRoot && pRoot->pLeft != NULL) {
            pRoot = pRoot->pLeft;
        }
        return pRoot;
    }
    Employee* deleteT(Employee* pRoot, int key)
    {
        if (pRoot == NULL)
            return pRoot;

        // Step 1: search for the node
        if (key < pRoot->getCode()) {
            pRoot->pLeft = deleteT(pRoot->pLeft, key);
        }
        else if (key > pRoot->getCode()) {
            pRoot->pRight = deleteT(pRoot->pRight, key);
        }
        else { //node to be deelted is found
            
            if (pRoot->pLeft == NULL) { //works in first two cases
                Employee* temp = pRoot->pRight;
                delete pRoot;
                return temp;
            }
            else if (pRoot->pRight == NULL) {
                Employee* temp = pRoot->pLeft;
                delete pRoot;
                return temp;
            }
             //third case:
            Employee* temp = findMin(pRoot->pRight); //to get the lowest right node

            //swapping between nodes
            pRoot->pLeft = temp->pLeft;
            pRoot->pRight = temp->pRight;

            delete temp;
        }

        return pRoot;
    }

    int getHeight(Employee* pRoot,int height) {
        if (pRoot) {//pushing into a new node means that the height is increased by one
            height++;
            if (height > treeMaxHeight) treeMaxHeight = height;
            getHeight(pRoot->pLeft,height);
            getHeight(pRoot->pRight,height);
        }
        height--;
        return height;
    }
    bool hasDownwardPath(Employee* node, int path[], int index, int size)
    {
        if (index == size)
            return true;        // full path is found

        if (node == NULL)
            return false;

        if (node->getCode() == path[index])
        {
            if (hasDownwardPath(node->pLeft, path, index + 1, size) || hasDownwardPath(node->pRight, path, index + 1, size))
            {
                return true;
            }
        }

        // Restart matching from beginning
        return hasDownwardPath(node->pLeft, path, 0, size) || hasDownwardPath(node->pRight, path, 0, size);
    }


    //bouns task :
    int _countLeaves(Employee* pRoot) {
        
        if (pRoot == NULL)
            return 0;

        if (pRoot->pLeft == NULL && pRoot->pRight == NULL)
            return 1;

        return _countLeaves(pRoot->pLeft) + _countLeaves(pRoot->pRight);
    }
public:
    BinaryTree(){
        pParent = NULL;
    }
    void insertNode(Employee* data) {
       pParent =  insert(pParent,data);
    }
    Employee* searchTree(int code) {
        Employee* pRoot;
        pRoot = pParent;
        while (pRoot && pRoot->getCode() != code) {
            if (code < pRoot->getCode()) {
                pRoot = pRoot->pLeft;
            }
            else {
                pRoot = pRoot->pRight;
            }
        }
        return pRoot;
    }
    void inOrderTraverse() {
        inOrder(pParent);
    }
    void preOrderTraverse() {
        preOrder(pParent);
    }
    void postOrderTraverse(){
        postOrder(pParent);
    }
    void deleteNode(int key) {
        deleteT(pParent, key);
    }
    int getTreeHeight() {
        treeMaxHeight = 0; //initialize the current maximum height for the tree
        getHeight(pParent,0); 
        return treeMaxHeight;
    }
    bool containsPath(int path[], int size)
    {
        return hasDownwardPath(pParent, path, 0, size);
    }
    int countLeaves() {
        _countLeaves(pParent);
    }
};



int main() {
	

    Employee* emp1 = new Employee("ahmed", 1, 3000);
    Employee* emp2 = new Employee("ayman", 12, 12000);
    Employee* emp3 = new Employee("tarek", 3, 4000);
    Employee* emp4 = new Employee("mostafa", 11, 6500);
    Employee* emp5 = new Employee("ashraf", 9, 4200);
    Employee* emp6 = new Employee("hany", 23, 36000);
    Employee* emp7 = new Employee("fady", 30, 21000);



    BinaryTree t1;

    t1.insertNode(emp1);
    t1.insertNode(emp2);
    t1.insertNode(emp3);
    t1.insertNode(emp4);
    t1.insertNode(emp5);
    t1.insertNode(emp6);
    t1.insertNode(emp7);


    t1.inOrderTraverse();
    cout << t1.getTreeHeight();

    cout << "====================" << endl;
    t1.deleteNode(9);
    t1.inOrderTraverse();
    cout << t1.getTreeHeight() << endl;

    int arr[] = {12,23,30}; //when traversing the list inorder traverse this sequence of IDs will be generated

    int arr2[] = { 13,23,30 }; //when traversing the list "inorder traverse" this sequence of IDs will not be generated
    cout << t1.containsPath(arr, 3) << endl; //return 1
    cout << t1.containsPath(arr2, 3) << endl; //return 0

	return 0;
}