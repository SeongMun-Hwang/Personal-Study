#include <iostream>
#include <vector>
#include <algorithm>
#include <stack>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);


    int N, M;
    cin >> N >> M;

    vector<vector<bool>> bad(N + 1, vector<bool>(N + 1, false));

    for (int i = 0; i < M; i++) {
        int a, b;
        cin >> a >> b;
        bad[a][b] = true;
        bad[b][a] = true;
    }

    int ans = 0;

    for (int i = 1; i <= N; i++) {
        for (int j = i + 1; j <= N; j++) {
            if (bad[i][j]) continue;
            for (int k = j + 1; k <= N; k++) {
                if (bad[i][k] || bad[j][k]) continue;
                ans++;
            }
        }
    }

    cout << ans << "\n";
    return 0;
}