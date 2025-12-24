//this file contains only the code related to the bonus task!

#include <iostream>
using namespace std;

class BinaryTree {

private:
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

    BinaryTree t1;x

    t1.insertNode(emp1);
    t1.insertNode(emp2);
    t1.insertNode(emp3);
    t1.insertNode(emp4);
    t1.insertNode(emp5);
    t1.insertNode(emp6);
    t1.insertNode(emp7);
	
    cout << "leaves" << t1.countLeaves() << endl;  //  --> 2

	return 0;
}