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

    virtual double Area() = 0;

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
    double Area() override
    {
        return dim1 * dim2;
    }
};

class Square : public Geoshape
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

double totalAreaV1(Rect *rPtr,Circle *cPtr,Tri *tPtr, Square *sPtr){
    double sum = 0;
    sum += rPtr ->Area();
    sum += cPtr ->Area();
    sum += tPtr ->Area();
    sum += sPtr ->Area();
    return sum;

}



double totalAreaV2(Geoshape** gPtr, int Count){
    double sum = 0;
    for(int i=0 ; i<Count; i++)
    {
        sum += gPtr[i]->Area();
    }
    return sum;
}
int main()
{

Rect* rPtr1 = new Rect(5,5);
Circle* cPtr2 = new Circle(1);
Tri* tPtr3 = new Tri(5,5);
Square* sPtr4 = new Square(5);

cout<<totalAreaV1(rPtr1,cPtr2,tPtr3,sPtr4)<<endl;




Geoshape* gPtr[4] = {rPtr1,cPtr2,tPtr3,sPtr4}; //array of shapes
cout<<totalAreaV2(gPtr,sizeof(gPtr)/sizeof(gPtr[0]))<<endl;





    return 0;
}
