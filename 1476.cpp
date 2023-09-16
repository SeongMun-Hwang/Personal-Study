#include <iostream>
#include <vector>
#include <numeric>
#include<algorithm>

using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);
    int isekai[3] = { 1,1,1 };
    int e, s, m, year = 1;
    cin >> e >> s >> m;
    if (e == s && s == m) {
        cout << e;
        return 0;
    }
    while (1) {
        if (isekai[0] == 15) { isekai[0] = 1; }
        else { isekai[0]++; }
        if (isekai[1] == 28) { isekai[1] = 1; }
        else { isekai[1]++; }
        if (isekai[2] == 19) { isekai[2] = 1; }
        else { isekai[2]++; }
        year++;
        if (isekai[0] == e && isekai[1] == s && isekai[2] == m) {
            cout << year;
            return 0;
        }
    }
    return 0;
}