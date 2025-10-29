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

class Picture
{
private:
    Line *lPtr; //pointer to array of lines
    int lSize;
    public:
    Picture()
    {
        lPtr=NULL;
        lSize=0;
    }
    Picture(Line *ptr, int Size)
    {
        lPtr = ptr;
        lSize= Size;
    }

    void SetLines(Line *_lPtr,int _lSize)
    {
        lPtr=_lPtr;
        lSize=_lSize;
    }

    void Execute()
    {
        if(lSize > 0){
            for (int i = 0; i < lSize; i++)
            {
                lPtr[i].Print();
            }
        }
        else{
            cout<<"Picture is empty !!!"<<endl;
        }
    }
};

int main()
{
    Line lines[5];
    lines[0].setStartPoint(0,0);
    lines[0].setEndPoint(5,5);

    lines[1].setStartPoint(5,5);
    lines[1].setEndPoint(15,15);

    lines[2].setStartPoint(20,20);
    lines[2].setEndPoint(25,25);

    lines[3].setStartPoint(30,30);
    lines[3].setEndPoint(35,35);

    lines[4].setStartPoint(40,40);
    lines[4].setEndPoint(45,45);


    Picture pic(lines,sizeof(lines)/sizeof(lines[0]));

    pic.Execute(); //drawing lines

    pic.SetLines(NULL,0); //clearing the picture

    pic.Execute(); //drawing lines


    return 0;
}
