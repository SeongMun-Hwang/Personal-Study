#include <iostream>
#include <vector>
#include <cmath>

using namespace std;

const int MAX = 1000000;

vector<bool> sieve() {
    vector<bool> is_prime(MAX + 1, true);
    is_prime[0] = false;
    is_prime[1] = false;
    for (int i = 4; i <= MAX; i += 2) {
        is_prime[i] = false;
    }
    int limit = sqrt(MAX);
    for (int i = 3; i <= limit; i += 2) {
        if (is_prime[i]) {
            for (int j = i * i; j <= MAX; j += 2 * i) {
                is_prime[j] = false;
            }
        }
    }
    return is_prime;
}

pair<int, int> goldbach(int n, const vector<bool>& primes) {
    if (n == 4) {
        return { 2, 2 };
    }
    for (int i = 3; i <= n / 2; i += 2) {
        if (primes[i] && primes[n - i]) {
            return { i, n - i };
        }
    }
    return { -1, -1 };
}

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    vector<bool> primes = sieve();

    while (true) {
        int n;
        cin >> n;
        if (n == 0) break;

        pair<int, int> result = goldbach(n, primes);
        if (result.first != -1 && result.second != -1) {
            cout << n << " = " << result.first << " + " << result.second << '\n';
        }
        else {
            cout << "Goldbach's conjecture is wrong." << '\n';
        }
    }
    return 0;
}
