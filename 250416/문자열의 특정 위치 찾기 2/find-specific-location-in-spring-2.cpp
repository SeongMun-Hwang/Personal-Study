#include <iostream>
#include <vector>
using namespace std;

int main() {
    vector<string> v = { "apple","banana","grape","blueberry","orange" };
    char c;
    cin >> c;
    int cnt=0;
    for (int i = 0; i < v.size(); i++) {
        if(v[i][2]==c||v[i][3]==c) {
            cout << v[i] << "\n";
            cnt++;
        }
    }
    cout << cnt;
    return 0;
}