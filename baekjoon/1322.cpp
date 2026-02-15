#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(NULL);

    long long X, K;
    cin >> X >> K;

    long long Y = 0;
    long long bit = 1; 

    while (K > 0) {
        if ((X & bit) == 0) { 
            if (K & 1) Y |= bit;
            K >>= 1;
        }
        bit <<= 1;
    }

    cout << Y;
    
    return 0;
}