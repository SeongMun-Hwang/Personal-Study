#include <iostream>
using namespace std;

int main() {
    while(true){
        int n;
        cin >> n;
        if(n<25) cout << "Lower";
        else if (n>25) cout << "Higher";
        else {
            cout << "Good";
            break;
        }
        cout <<"\n";
    }
    return 0;
}