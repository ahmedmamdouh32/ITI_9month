#include <iostream>
using namespace std;
 
int main()
{
    unsigned long long numberOfOranges, maxSizeOfJuicer, wasteSize;
    cin >> numberOfOranges >> maxSizeOfJuicer >> wasteSize;
 
    unsigned long long orangeSize;
    unsigned long long currentWaste = 0;
    unsigned long long cleaningCount = 0;
 
    for (unsigned long long i = 0; i < numberOfOranges; i++) {
        cin >> orangeSize;
 
        if (orangeSize > maxSizeOfJuicer) 
            continue;
 
        currentWaste += orangeSize;
 
        if (currentWaste > wasteSize) {
            cleaningCount++;
            currentWaste = 0;
        }
    }
 
    cout << cleaningCount;
    return 0;
}