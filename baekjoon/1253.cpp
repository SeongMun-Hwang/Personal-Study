#include <iostream>
#include <vector>
#include <algorithm>
#include <stack>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int N;
    cin >> N;
    vector<long long> A(N);
    for (int i = 0; i < N; i++) cin >> A[i];

    sort(A.begin(), A.end());

    int good = 0;

    for (int i = 0; i < N; i++) {
        int l = 0, r = N - 1;
        long long target = A[i];

        while (l < r) {
            if (l == i) { l++; continue; }
            if (r == i) { r--; continue; }

            long long sum = A[l] + A[r];

            if (sum == target) {
                good++;
                break;
            }
            else if (sum < target) l++;
            else r--;
        }
    }

    cout << good << '\n';
    return 0;
}