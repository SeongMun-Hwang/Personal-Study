#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int cal(int n) {
    std::vector<int> dp(n + 1, 0);

    for (int i = 2; i <= n; ++i) {
        dp[i] = dp[i - 1] + 1;

        if (i % 2 == 0) {
            dp[i] = std::min(dp[i], dp[i / 2] + 1);
        }

        if (i % 3 == 0) {
            dp[i] = std::min(dp[i], dp[i / 3] + 1);
        }
    }
    return dp[n];
}

int main() {
    int n;
    cin >> n;

    cout << cal(n) << "\n";

    return 0;
}
