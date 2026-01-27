#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int T;
    cin >> T;

    if (T == 1) {
        unsigned long long A, B;
        cin >> A >> B;
        unsigned long long S = A + B;

        string res(13, 'a');
        for (int i = 12; i >= 0; i--) {
            res[i] = char('a' + (S % 26));
            S /= 26;
        }
        cout << res << '\n';
    }
    else {
        string s;
        cin >> s;

        unsigned long long val = 0;
        for (char c : s) {
            val = val * 26 + (c - 'a');
        }
        cout << val << '\n';
    }

    return 0;
}