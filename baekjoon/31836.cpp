#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int N;
    cin >> N;

    vector<int> a, b;

    int i = N;
    while (i >= 3) {
        a.push_back(i);
        b.push_back(i - 1);
        b.push_back(i - 2);
        i -= 3;
    }

    if (i == 2) {
        a.push_back(2);
        b.push_back(1);
    }

    cout << a.size() << "\n";
    for (int x : a) cout << x << " ";
    cout << "\n";

    cout << b.size() << "\n";
    for (int x : b) cout << x << " ";
    cout << "\n";

    return 0;
}