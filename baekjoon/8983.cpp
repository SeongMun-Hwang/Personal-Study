#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int M, N;
    long long L;
    cin >> M >> N >> L;

    vector<long long> stand(M);
    for (int i = 0; i < M; i++)
        cin >> stand[i];

    sort(stand.begin(), stand.end());

    int cnt = 0;

    for (int i = 0; i < N; i++) {
        long long a, b;
        cin >> a >> b;

        if (b > L) continue;

        long long remain = L - b;
        long long left = a - remain;
        long long right = a + remain;

        auto it = lower_bound(stand.begin(), stand.end(), left);

        if (it != stand.end() && *it <= right)
            cnt++;
    }

    cout << cnt;

    return 0;
}