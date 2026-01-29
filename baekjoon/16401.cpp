#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int M, N;
    cin >> M >> N;

    vector<long long> L(N);
    long long max_length = 0;
    for (int i = 0; i < N; i++) {
        cin >> L[i];
        max_length = max(max_length, L[i]);
    }

    long long left = 1, right = max_length, result = 0;
    while (left <= right) {
        long long mid = (left + right) / 2;
        long long cnt = 0;

        for (long long len : L) {
            cnt += len / mid;
            if (cnt >= M) break;
        }
        if (cnt >= M) {
            result = mid;
            left = mid + 1;
        }
        else {
            right = mid - 1;
        }
    }
    cout << result;

    return 0;
}