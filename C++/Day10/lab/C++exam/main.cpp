#include <iostream>

using namespace std;

class parent{
    int age;


public :


    parent(){
        age = 50;
        cout<<"Iam the default constructor"<<endl;
    }

    parent(parent& P1){
        age = P1.age;
        cout<<"Iam the copy constructor"<<endl;
    }


void setAge(int n){
    age = n;
}
int getAge(){
    return age;
}

};

void show(parent& p){
    cout<<"Iam the show function"<<p.getAge()<<endl;
}

int main(){

parent P1;
//parent P2 = P1;
show(P1);









return 0;

}
