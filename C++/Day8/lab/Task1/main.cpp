//1-Complex --done--
////cpy ctor [useless] --done--
////= operator [useless] --done
////c1+c2 --done--
////c1+10 --done--
////c1+=c2 --done--
////c1++ --done--
////++c1 --done--
////c1>c2 --done--

//10+c1 [standalone] --done--

#include <iostream>
using namespace std;

class Complex {
private:
	int real;
	int imag;
public:
	void setReal(int r) {
		real = r;
	}
	int getReal() {
		return real;
	}

	void setImg(int i) {
		imag = i;
	}
	int getImg() {
		return imag;
	}


	Complex() {
		real = 0;
		imag = 0;
		//cout << "Constructor Call!!!" << endl;
	}

	Complex(int r, int i) {
		real = r;
		imag = i;
		//cout << "Constructor Call!!!" << endl;
	}

	Complex(const Complex& oldObj) { //copy constructor
		real = oldObj.real;
		imag = oldObj.imag;
	}

	Complex& operator=(const Complex& right) { //assignment operator
		real = right.real;
		imag = right.imag;
		return *this;
	}

	Complex operator+(const Complex& right){
	    Complex result;
        result.real = real + right.real;
        result.imag = imag + right.imag;
        return result;
	}

	Complex operator+(int number){
	    Complex result;
        result.real = real + number;
        result.imag = imag;
        return result;
	}

    Complex& operator+=(const Complex& right){
        real += right.real;
        imag += right.imag;
        return *this;
    }

    Complex& operator++(){
        real++;
        imag++;
        return *this;
    }

    Complex operator++(int){
        Complex result;
        result.real = real++;
        result.imag = imag++;
        return result;
    }


    int operator>(const Complex& right){
        if(real > right.real && imag > right.imag) return 1;
        else return 0;
    }
    void print(){
        cout<<real<<" + "<<imag<<"i"<<endl;
    }


};


Complex operator+(int num,Complex right){
    Complex result(right.getReal() +num, right.getImg());
    return result;
}

int main()
{
    Complex c1(3, 4);
    Complex c2(2, 5);

    cout << "c1: ";
    c1.print();
    cout << "c2: ";
    c2.print();

    Complex c3 = c1 + c2;
    cout << "c1 + c2 = ";
    c3.print();

    Complex c4 = c1 + 10;
    cout << "c1 + 10 = ";
    c4.print();

    Complex c5 = 10 + c1;
    cout << "10 + c1 = ";
    c5.print();

    c1 += c2;
    cout << "After c1 += c2, c1 = ";
    c1.print();

    ++c1;
    cout << "After ++c1, c1 = ";
    c1.print();

    c1++;
    cout << "After c1++, c1 = ";
    c1.print();

    if (c1 > c2)
        cout << "c1 is greater than c2" << endl;
    else
        cout << "c1 is not greater than c2" << endl;

    Complex c6;
    c6 = c2;
    cout << "After c6 = c2, c6 = ";
    c6.print();

    Complex c7(c1);
    cout << "Copy constructed c7 from c1: ";
    c7.print();
}


