//OBSERVE
//1-class Complex
//+  ctor()cout,ctor(,)cout,ctor(int)cout ,dest()cout
///in main
////Complex c1,c2,c3
////pass values
////c3=AddComplex(c1,c2); //pass by value
//o/p
//with observe -> NO static variable  with ur eyes
//ctor
//cotr
//des
//des
//des
//# of ctor != # of dest
//Why -> tomorrow
#include <iostream>

using namespace std;

class Complex{
    private:
        int real;
        int img;


    public:
        void setReal(int _real){
            real = _real;
        }
        int getReal(){
            return real;
            }
        void setImg(int _img){
            img = _img;
        }
        int getImg(){
            return img;
        }

        Complex(){
            cout<<"Constructor Call!!!"<<endl;
        }
        Complex(int _real, int _img){
            real = _real;
            img  = _img;
            cout<<"Constructor Call!!!"<<endl;
        }
        Complex(int number){
            real = number;
            img  = number;
            cout<<"Constructor Call!!!"<<endl;
      }

        ~Complex(){
            cout<<"Destructor Call!!!"<<endl;
        }

};

Complex Add(Complex c1, Complex c2){
    Complex result(c1.getReal() + c1.getReal(),
                   c1.getImg() + c2.getImg());

    return result;
}
int main()
{

    Complex c1(1,1),c2(2),c3;
    c3 = Add(c1,c2);



    return 0;
}
