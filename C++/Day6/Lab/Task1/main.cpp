//Lab Assignments
//class Complex
//{
//real,img
//setters&getters
//print
//Add MEMBER
//};
//Add Standalone

///real img  print
///3     4   3+4i
///3    -4   3-4i
///3     1   3+i
///3    -1   3-i
///0     1   i
///0    -1   -i
///0     0   0
///1     0   1

#include <iostream>
using namespace std;
class Complex
{
private:
    int real;
    int img;

public:
    void setReal(int _real)
    {
        real = _real;
    }
    int getReal()
    {
        return real;
    }
    void setImg(int _img)
    {
        img = _img;
    }
    int getImg()
    {
        return img;
    }


    void print()
    {
        if (real == 0 && img == 0)
        {
            cout << "0";
        }
        else if (real == 0)
        {
            if (img == 1)
                cout << "i";
            else if (img == -1)
                cout << "-i";
            else
                cout << img << "i";
        }
        else if (img == 0)
        {
            cout << real;
        }
        else
        {
            cout << real;
            if (img > 0)
            {
                if (img == 1)
                    cout << "+i";
                else
                    cout << "+" << img << "i";
            }
            else
            {
                if (img == -1)
                    cout << "-i";
                else
                    cout << img << "i";
            }
        }

    }

    void add(Complex c){
        real += c.real;
        img += c.img;
    }
};


//Standalone Function
Complex add(Complex c1, Complex c2){
     c1.add(c2);
     return c1;
}


using namespace std;

int main()
{

    Complex c1; //1+2i
    c1.setReal(1);
    c1.setImg(2);

    Complex c2; //-3-5i
    c2.setReal(-3);
    c2.setImg(-5);

    //using member function
    c1.print();
    cout << " + ";
    c2.print();
    cout<< " = ";
    c1.add(c2); //-2-3i
    c1.print();
    cout<<endl;


    //using standalone function
    c1.print();
    cout << " + ";
    c2.print();
    cout<< " = ";
    Complex result = add(c1,c2);
    result.print();




    return 0;
}
