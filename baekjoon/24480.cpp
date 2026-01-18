#include <iostream>
#include <vector>
#include <algorithm>
#include <stack>
using namespace std;

int N, M, R;
vector<vector<int>> adj;
vector<int> visited;
int order = 1;

void dfs(int u) {
    visited[u] = order++;
    for (int v : adj[u]) {
        if (visited[v] == 0) {
            dfs(v);
        }
    }
}

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    cin >> N >> M >> R;
    adj.resize(N + 1);
    visited.assign(N + 1, 0);

    for (int i = 0; i < M; i++) {
        int u, v;
        cin >> u >> v;
        adj[u].push_back(v);
        adj[v].push_back(u);
    }

    for (int i = 1; i <= N; i++) {
        sort(adj[i].begin(), adj[i].end(), greater<int>());
    }

    dfs(R);

    for (int i = 1; i <= N; i++) {
        cout << visited[i] << '\n';
    }

    return 0;
}