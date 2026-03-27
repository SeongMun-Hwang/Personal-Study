#include <iostream>
#include <vector>
#include <algorithm>
#include <regex>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(0);

    long long A, X;
    const long long MOD = 1000000007LL;

    if (!(cin >> A >> X)) return 0;

    long long result = 1;
    A %= MOD;

    while (X > 0) {
        if (X % 2 == 1) {
            result = (result * A) % MOD;
        }
        A = (A * A) % MOD;
        X /= 2;
    }

    cout << result << endl;

    return 0;
}