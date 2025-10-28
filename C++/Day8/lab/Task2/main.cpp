//2- stack
///cpy ctor [MUST] --done--
///=operator [MUST] --done--
///Stack Reverse(){} --done--



#include <iostream>

using namespace std;




class Stack{

private:
    int* ptr;
    int _size;
    int tos;

public:
    Stack(){
        tos = 0;
        _size = 5;
        ptr = new int[_size]; //default size
        cout<<"Constructor Call !!!"<<endl;
    }
    Stack(int memory_size){
        tos = 0;
        _size = memory_size;
        ptr = new int[_size]; //user choosen size
        cout<<"Constructor Call !!!"<<endl;
    }

    Stack(Stack& oldObj){ //copy constructor
        _size = oldObj._size;
        tos = oldObj.tos;
        ptr = new int[_size]; //allocate new memory
        for(int i=0 ; i<tos;i++){
            ptr[i] = oldObj.ptr[i]; //make a copy of stack data
        }
    }

    Stack& operator=(const Stack& oldObj){
        delete [] ptr; //delete current memory allocation
        _size = oldObj._size;
        tos = oldObj.tos;
        ptr = new int [_size]; //allocate new memory;
        for(int i=0 ; i<tos;i++){
            ptr[i] = oldObj.ptr[i]; //make a copy of stack data
        }
        return *this;
    }

    Stack Reverse() {
        Stack temp;
        temp._size = _size;
        temp.tos = tos;

        // Copy elements in reverse order
        for (int i = 0; i < tos; i++) {
            temp.ptr[i] = ptr[tos - 1 - i];
        }

    return temp;
}

    ~Stack(){
        for(int i = 0;i<tos;i++){
            ptr[i] = -1; //clearing data
        }
        delete [] ptr; //deleting the data
        cout<<"Destructor Call !!!"<<endl;
    }
    void push(int number){
        if(!isFull()){
            ptr[tos++] = number;
        }
        else{
            cout<<"Stack is full !"<<endl;
        }
    }

    int pop(){
        if(!isEmpty()){
            return ptr[--tos];
        }
        else{
            cout<<"Stack is empty !"<<endl;
        }
    }
    int isFull(){
        return (tos == _size);
    }
    int isEmpty(){
        return (tos ==0);
    }



    friend void viewStack(Stack s);

};
void viewStack(Stack s){
    for(int i=0 ;i<s.tos ; i++){
        cout<<s.ptr[i]<<endl;
    }
}

int main() {
    Stack s1(5);
    s1.push(1);
    s1.push(2);
    s1.push(3);
    s1.push(4);
    s1.push(5);

    cout << "Original stack:" << endl;
    viewStack(s1);

    Stack s2(50);
    s2 = s1.Reverse();



    //cout << "Reversed stack:" << endl;


    //viewStack(s2);


    Stack s3(4);

    Stack s4 = s3 = s1;


    s4 = s3 = s1;
    viewStack(s3);


    return 0;
}
