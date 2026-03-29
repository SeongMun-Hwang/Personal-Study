#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

const int INF = 1e9;
int fileSize[501];
int sum[501];
int dp[501][501];

void solve() {
    int K;
    cin >> K;

    for (int i = 1; i <= K; i++) {
        cin >> fileSize[i];
        sum[i] = sum[i - 1] + fileSize[i];
    }

    for (int gap = 1; gap < K; gap++) {
        for (int i = 1; i + gap <= K; i++) {
            int j = i + gap;
            dp[i][j] = INF;

            for (int k = i; k < j; k++) {
                dp[i][j] = min(dp[i][j], dp[i][k] + dp[k + 1][j] + (sum[j] - sum[i - 1]));
            }
        }
    }

    cout << dp[1][K] << endl;
}

int main() {
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);

    int T;
    cin >> T;
    while (T--) {
        solve();
    }

    return 0;
}