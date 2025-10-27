
#include <iostream>

using namespace std;

class Queue{
private:
    int *ptr;
    int _size;
    int elements_counter;

public:
    Queue(){
        _size = 5;
        ptr = new int [_size];
        elements_counter = 0;
        cout<<"Constructor Call!!!"<<endl;
    }

    Queue(int user_size){
        _size = user_size;
        ptr = new int [_size];
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

    int isFull(){
        return (elements_counter == _size);
    }
    int isEmpty(){
        return(elements_counter == 0);
    }


    void enqueue(int number){
        if(!isFull()){
            ptr[elements_counter++] = number;
        }
        else{
            cout<<"Queue is full !"<<endl;
        }
    }

    int dequeue(){
        if(!isEmpty()){
            int result = ptr[0];
            for(int i=1 ; i<elements_counter;i++){
                swap(ptr[i],ptr[i-1]);
            }
        elements_counter--;
        }
        else{
            cout<<"Queue is empty"<<endl;
        }
    }


friend void viewQueue(Queue q);

};

void viewQueue(Queue q){
    for(int i=0 ;i<q.elements_counter;i++){
        cout<<q.ptr[i]<<endl;
    }
}

int main()
{

Queue q(5);
q.enqueue(1);
q.enqueue(2);

q.dequeue();
q.enqueue(6);
//viewQueue(q);

    return 0;
}
