///3-Composition with [debugging]
//class point ALL
//class Line
//class Rect

#include <iostream>

using namespace std;

class Point{
private:
    int x;
    int y;

public:
    void setX(int n){
        x = n;
    }
    int getX(){
        return x;
    }

    void setY(int n){
        y = n;
    }
    int getY(){
        return y;
    }

    void setPoint(int x, int y)
    {
        this->x = x;
        this->y = y;

    }

    Point(){
        x = y = 0;
    }

    Point(int _x, int _y){
        x = _x;
        y = _y;
    }

    void print(){
        cout<<"x="<<x<<", y="<<y<<endl;
    }

};


class Line{

private:
    Point startPoint;
    Point endPoint;

public:
    void setStartPoint(int x, int y){
       startPoint.setPoint(x,y);
    }
    Point getStartPoint(){
        return startPoint;
    }

    void setEndPoint(int x, int y){
       endPoint.setPoint(x,y);
    }
    Point getEndPoint(){
        return endPoint;
    }

    Line(){
    }
    Line(int s1, int s2, int e1 , int e2):startPoint(s1,s2),endPoint(e1,e2){
    }


    void Print(){
        cout<<"Start Point :";
        startPoint.print();
        cout<<"End Point :";
        endPoint.print();
    }
};

class Rect
{
private:
    Point upperLeft;
    Point lowerRight;

public:
    void setUpperLeft(int x, int y){
       upperLeft.setPoint(x,y);
    }
    Point getUpperLeft(){
        return upperLeft;
    }

    void setLowerRight(int x, int y){
       lowerRight.setPoint(x,y);
    }
    Point getLowerRight(){
        return lowerRight;
    }

    Rect(){
    }
    Rect(int x1,int y1,int x2,int y2):upperLeft(x1,y1),lowerRight(x2,y2){

    }

    void Print()
    {
        cout<<"Upper-left Point :";
        upperLeft.print();
        cout<<"Lower-right Point :";
        lowerRight.print();
    }
};

int main()
{
cout<<"-------------------------Line--------------------------"<<endl;

    Line line1;
    line1.Print();

    Line line2(1,2,3,4);
    line2.Print();
cout<<"-----------------------Rectangle-----------------------"<<endl;
    Rect rectangle1;
    rectangle1.Print();

    Rect rectangle2(1,2,3,4);
    rectangle2.Print();
    return 0;
}
