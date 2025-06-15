#include <iostream>
using namespace std;

int main() {
    int cnt_three = 0;
    int cnt_five = 0;
    for(int i=0;i<10;i++){
        int n;
        cin >> n;
        if(n%3==0) cnt_three++;
        if(n%5==0) cnt_five++;
    }
    cout << cnt_three << " " << cnt_five;
    return 0;
}