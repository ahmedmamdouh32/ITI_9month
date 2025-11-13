// CollegeCourse Class
#include <iostream>
#include<string.h>
using namespace std;

class parent {


        static int z;


public :
    int y;

	parent() {
		y = 0;
		cout<<z;
	}
	parent(int n)
	{
		y = n;
	}
};

int parent::z = 0;


int main() {

parent* p1 = new parent(5);
cout<<p1->y;
    return 0;
}
