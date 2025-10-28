#include <iostream>
using namespace std;

class Complex{

private:
    int real;
    int img;
    static int counter;
public :
    Complex(){
        counter++;
    }
    Complex(int _real, int _img){
        real = _real;
        img = _img;
        counter++;
    }

    static int getCounter(){
        return counter;
    }
};

int Complex::counter = 0; //initialization of static variable
int main()
{
    Complex c1(2,3);
    Complex c2,c3,c4;
    cout<< Complex::getCounter();
    return 0;
}
