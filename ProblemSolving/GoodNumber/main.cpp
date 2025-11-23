#include <iostream>

using namespace std;

int main()
{
    int n,k;
    cin >>n>> k;
    string s[n];

    int goodNumbersCounter = 0;

    for(int i = 0 ; i< n ; i++)
    {
        cin>>s[i];
    }


    for(int i = 0 ; i < n ; i++)
    {
        int digits_map[10] = {0};
        for(int j = 0 ; j<s[i].length(); j++)
        {
            if((int)(s[i][j] - '0') <= k)
            {
                digits_map[s[i][j] - '0'] = 1;
            }
        }
        int mapCounter = 0;
        for(int m = 0; m <= k ; m++)
            {
                mapCounter+=digits_map[m];
            }

        if(mapCounter == k+1) {goodNumbersCounter++;}

    }

    cout<<goodNumbersCounter;
    return 0;
}
