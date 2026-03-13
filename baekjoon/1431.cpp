#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int getSum(string s) {
    int sum = 0;
    for (int i = 0; i < s.length(); i++) {
        if (s[i] >= '0' && s[i] <= '9') {
            sum += s[i] - '0';
        }
    }
    return sum;
}

bool compare(string a, string b) {
    if (a.length() != b.length()) {
        return a.length() < b.length();
    }

    int sumA = getSum(a);
    int sumB = getSum(b);
    if (sumA != sumB) {
        return sumA < sumB;
    }

    return a < b;
}

int main() {
    ios::sync_with_stdio(false);
    cin.tie(0);

    int n;
    cin >> n;

    vector<string> guitars(n);
    for (int i = 0; i < n; i++) {
        cin >> guitars[i];
    }

    sort(guitars.begin(), guitars.end(), compare);

    for (int i = 0; i < n; i++) {
        cout << guitars[i] << "\n";
    }

    return 0;
}