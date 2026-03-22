#include <iostream>
#include <vector>
#include <algorithm>
#include <regex>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(0);


    int N, K;
    cin >> N >> K;

    vector<int> s(N), h(N);
    for (int i = 0; i < N; i++) cin >> s[i];
    for (int i = 0; i < N; i++) cin >> h[i];

    vector<int> dp(101, -1);
    dp[100] = 0;

    for (int i = 0; i < N; i++) {
        vector<int> next(101, -1);

        for (int hp = 0; hp <= 100; hp++) {
            if (dp[hp] == -1) continue;

            int nh = min(100, hp + K);

            next[nh] = max(next[nh], dp[hp]);

            if (nh >= h[i]) {
                next[nh - h[i]] = max(next[nh - h[i]], dp[hp] + s[i]);
            }
        }

        dp = next;
    }

    int answer = 0;
    for (int hp = 0; hp <= 100; hp++) {
        answer = max(answer, dp[hp]);
    }

    cout << answer << '\n';

    return 0;
}