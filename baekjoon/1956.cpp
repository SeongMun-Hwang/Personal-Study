#include <iostream>
#include <vector>
#include <algorithm>
#include <stack>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

    int V, E;
    cin >> V >> E;

    vector<vector<int>> dist(V + 1, vector<int>(V + 1, 1e9));

    for (int i = 1; i <= V; i++)
        dist[i][i] = 0;

    for (int i = 0; i < E; i++) {
        int a, b, c;
        cin >> a >> b >> c;
        dist[a][b] = c;
    }

    for (int k = 1; k <= V; k++) {
        for (int i = 1; i <= V; i++) {
            for (int j = 1; j <= V; j++) {
                if (dist[i][k] + dist[k][j] < dist[i][j]) {
                    dist[i][j] = dist[i][k] + dist[k][j];
                }
            }
        }
    }

    int ans = 1e9;
    for (int i = 1; i <= V; i++) {
        for (int j = 1; j <= V; j++) {
            if (i == j) continue;
            if (dist[i][j] < 1e9 && dist[j][i] < 1e9) {
                ans = min(ans, dist[i][j] + dist[j][i]);
            }
        }
    }

    if (ans == 1e9) cout << -1 << "\n";
    else cout << ans << "\n";

    return 0;
}