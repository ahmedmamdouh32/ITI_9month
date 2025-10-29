#include <iostream>
using namespace std;

class Geoshape
{
protected:
    double dim1;
    double dim2;

public:
    void SetDim1(double _dim1)
    {
        dim1 = _dim1;
    }
    double GetDim1()
    {
        return dim1;
    }
    void SetDim2(double _dim2)
    {
        dim2 = _dim2;
    }
    double GetDim2()
    {
        return dim2;
    }

    Geoshape()
    {
        dim1 = dim2 = 0;
        // cout << "Geo def ctor" << endl;
    }
    Geoshape(double _dim1, double _dim2)
    {
        dim1 = _dim1;
        dim2 = _dim2;
        // cout << "Geo 2p ctor" << endl;
    }
    Geoshape(double _dim)
    {
        dim1 = dim2 = _dim;
        // cout << "Geo 1p ctor" << endl;
    }

    ~Geoshape()
    {
        // cout << "geo dest" << endl;
    }
};

class Rect : public Geoshape
{
public:
    Rect()
    {
        // cout << "Rect def ctor" << endl;
    }
    Rect(double _d1, double _d2)
    {
        dim1 = _d1;
        dim2 = _d2;
        // cout << "rect 2p ctor" << endl;
    }
    ~Rect()
    {
        // cout << "Rect dest" << endl;
    }
    double Area()
    {
        return dim1 * dim2;
    }
};

class Square : protected Geoshape
{
public:
    Square()
    {
        // cout << "square def ctor" << endl;
    }
    Square(double _dim)
    {
        dim1 = dim2 = _dim;
        // cout << "square 1p ctor" << endl;
    }
    ~Square()
    {
        // cout << "Sq dest" << endl;
    }
    void SetDim(double _dim)
    {
        dim1 = dim2 = _dim;
    }
    double Area()
    {
        return dim1 * dim2;
    }
};

class Circle : public Geoshape
{
public:
    Circle()
    {
        // cout << "circle def ctor" << endl;
    }
    Circle(double _radius)
    {
        dim1 = dim2 = _radius;
        // cout << "circle 1p ctor" << endl;
    }
    ~Circle()
    {
        // cout << "circle def dest" << endl;
    }
    double Area()
    {
        return 3.14 * dim1 * dim2;
    }
};

class Tri : public Geoshape
{
public:
    Tri()
    {
        // cout << "triangle def ctor" << endl;
    }
    Tri(double _base, double _height)
    {
        dim1 = _base;
        dim2 = _height;
        // cout << "triangle 2p ctor" << endl;
    }
    ~Tri()
    {
        // cout << "triangle def dest" << endl;
    }
    double Area()
    {
        return 0.5 * dim1 * dim2;
    }
};

int main()
{
    Rect r1;
    r1.SetDim1(5);
    r1.SetDim2(10);
    cout << "Rectangle Area = " << r1.Area() << endl;

    Rect r2(3, 7);
    cout << "Rectangle Area = " << r2.Area() << endl;


    Square s2(6);
    cout << "Square Area = " << s2.Area() << endl;



    Circle c2(1);
    cout << "Circle Area = " << c2.Area() << endl;


    Tri t2(8, 6);
    cout << "Triangle Area = " << t2.Area() << endl;



    return 0;
}
