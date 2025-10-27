#include <iostream>
using namespace std;


//helper function:
int absolute(int a, int b){
    if(a>b){
        return a-b;
    }
    else{
        return b-a;
    }
}

class Queue{
private:
    int *ptr;
    int _size;
    int head;
    int tail;
    int elements_counter;

public:
    int isFull(){
        return (elements_counter == _size);
    }
    int isEmpty(){
        return(elements_counter == 0);
    }

    Queue(){
        _size = 5;
        ptr = new int [_size];
        head = 0;
        tail = 0;
        elements_counter = 0;
        cout<<"Constructor Call!!!"<<endl;
    }

    Queue(int user_size){
        _size = user_size;
        ptr = new int [_size];
        head = 0;
        tail = 0;
        elements_counter = 0;
        cout<<"Constructor Call!!!"<<endl;
    }

    ~Queue(){
        for(int i=0 ;i<_size;i++){
            ptr[i] = -1;
        }
        delete [] ptr;
        cout<<"Destructor Call!!!"<<endl;
    }
    void enqueue(int number){
        if(!isFull()){
            ptr[tail++] = number;
            if(tail == _size){
                tail = 0;
            }
            elements_counter++;
        }
        else{
            cout<<"Queue is full !"<<endl;
        }
    }

    int dequeue(){
        if(!isEmpty()){
            int result = ptr[head];
            head++;
            if(head == _size){
                head = 0;
            }
            elements_counter--;
            return result;
        }
        else{
            cout<<"Queue is empty"<<endl;
            return -123; //or add exception
        }
    }


friend void viewQueue(Queue q);

};

void viewQueue(Queue q){
    int start = q.head;
    int End = q.tail;


    if(!q.isEmpty()){
        do{
            cout<<q.ptr[start]<<endl;
            start++;
            if(start == q._size){
                start = 0;
                }
        }while(start!=End);
    }
    else{
        cout<<"QUEUE is empty!!!"<<endl;
    }

}


int main()
{

Queue q(5);
q.enqueue(1);
q.enqueue(2);
q.enqueue(3);
q.enqueue(4);
q.enqueue(5);
q.enqueue(6);
q.enqueue(7);


cout<<q.dequeue()<<endl;
cout<<q.dequeue()<<endl;
cout<<q.dequeue()<<endl;
cout<<q.dequeue()<<endl;
cout<<q.dequeue()<<endl;
cout<<q.dequeue()<<endl;
viewQueue(q);

    return 0;
}
