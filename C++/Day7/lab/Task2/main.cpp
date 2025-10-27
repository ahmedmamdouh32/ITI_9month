//2-class Stack
///int*arr,int size,int tos ,static counter
///ctor() cout
///ctor(size) cout
///dest()  for loop -1 then delete [] arr then cout
///push,pop ,isfull,isempty


///ViewStack(Stack param)
//as standalone and friend fn

//in main write exactly
//Stack s1(10);
//push 4 or 6 times

//ViewStack(s1); //runs successfully
//ViewStack(s1); //fail
//Why? tomorrow isa

//try to print counter


#include <iostream>

using namespace std;

class Stack{

private:
    int* ptr;
    int _size;
    int tos;
    static int counter;

public:
    Stack(){
        _size = 5;
        ptr = new int[_size]; //default size
        cout<<"Constructor Call !!!"<<endl;
        counter++;
    }
    Stack(int memory_size){
        _size = memory_size;
        ptr = new int[_size]; //user choosen size
        cout<<"Constructor Call !!!"<<endl;
        counter++;
    }
    ~Stack(){
        for(int i = 0;i<tos;i++){
            ptr[i] = -1; //clearing data
        }
        delete [] ptr; //deleting the data
        cout<<"Destructor Call !!!"<<endl;
        counter--;
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

    static int getCounter(){
        return counter;
    }


    friend void viewStack(Stack s);


};


void viewStack(Stack s){
    for(int i=0 ;i<s.tos ; i++){
        cout<<s.ptr[i]<<endl;
    }
}

int Stack::counter = 0;
int main()
{

    Stack s1(10);
    s1.push(1);
    s1.push(2);
    s1.push(3);
    s1.push(4);
    s1.push(5);
    s1.push(6);
    cout<<"Live Stacks : "<<Stack::getCounter()<<endl;

    viewStack(s1);
    viewStack(s1);

    cout<<"Live Stacks : "<<Stack::getCounter()<<endl;
    return 0;
}
