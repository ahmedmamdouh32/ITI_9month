#include <iostream>

using namespace std;

int CalcAbsolute(int num1, int num2){
     int result = num1 > num2 ? num1-num2 : num2-num1;
     return result;
}

int main()
{

    int currentday=20;
    int currentmonth=10;
    int currentyear=2025;
    int day,month,year;
    bool correct_day = true;

    do
    {
        cout<<"Enter Year from 1973 -> 2023"<<endl;
        cin>>year;
    }
    while(year<1973 || year >2023);


    do
    {
        cout<<"Enter Your month"<<endl;
        cin>>month;
    }
    while(month<1 || month >12);


    do
    {
        cout<<"Enter your day : "<<endl;
        cin>>day;

        if(day < 1){
            correct_day = false;
        }
        else{
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if(day > 31) correct_day = false;

                    else correct_day = true;

                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if(day > 30)correct_day = false;

                    else correct_day = true;

                    break;

                case 2:
                    if(year%4 == 0){
                        if(day > 29) correct_day = false;
                        else correct_day = true;

                    }
                    else{
                        if(day > 28)correct_day = false;

                        else correct_day = true;
                    }
            }
        }
    }
    while(!correct_day);

    cout<<"You are "<<currentyear-year<<"y ";
    cout<<CalcAbsolute(currentmonth , month)<<" months, and ";
    cout<<CalcAbsolute(currentday , day)<<" days";

    return 0;
}
