#include <iostream>
using namespace std;

int main() {
    int n;
    cin >> n;
    if(n%4==0){
        if(n%100==0&&n%400!=0) {
            cout << "false";
            return 0;
        }
        else{
            cout << "true";
        }
    }
    else{
    cout << "false";
    }
    return 0;
}