#include <iostream>
#include <vector>
#include <algorithm>
#include <string>

using namespace std;

int dp[1001][1001];

int main() {
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);

    int n, m;
    cin >> n >> m;

    int maxSide = 0;

    for (int i = 1; i <= n; i++) {
        string row;
        cin >> row;
        for (int j = 1; j <= m; j++) {
            int val = row[j - 1] - '0';

            if (val == 1) {
                dp[i][j] = min({ dp[i - 1][j], dp[i][j - 1], dp[i - 1][j - 1] }) + 1;
                maxSide = max(maxSide, dp[i][j]);
            }
        }
    }

    cout << maxSide * maxSide << "\n";

    return 0;
}