#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0);

    int n;
    cin >> n;

    vector<vector<int>> dp(n, vector<int>(3));  // DP 테이블

    cin >> dp[0][0] >> dp[0][1] >> dp[0][2];
    for (int i = 1; i < n; i++) {
        int r, g, b;
        cin >> r >> g >> b;
        dp[i][0] = min(dp[i - 1][1], dp[i - 1][2]) + r;
        dp[i][1] = min(dp[i - 1][0], dp[i - 1][2]) + g;
        dp[i][2] = min(dp[i - 1][0], dp[i - 1][1]) + b;
    }

    cout << min({ dp[n - 1][0], dp[n - 1][1], dp[n - 1][2] }) << "\n";
    return 0;
}