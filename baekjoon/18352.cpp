#include <iostream>
#include <vector>
#include <cmath>
#include <climits>
#include<algorithm>
#include<queue>
using namespace std;

int N, M, K, X;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    cin >> N >> M >> K >> X;

    vector<vector<int>> graph(N + 1);
    for (int i = 0; i < M; i++) {
        int A, B;
        cin >> A >> B;
        graph[A].push_back(B);
    }
    vector<int> dist(N + 1, -1);
    queue<int> q;
    dist[X] = 0;
    q.push(X);

    while (!q.empty()) {
        int current = q.front();
        q.pop();

        for (int next : graph[current]) {
            if (dist[next] == -1) {
                dist[next] = dist[current] + 1;
                q.push(next);
            }
        }
    }
    bool connected = false;
    for (int i = 1; i <= N; i++) {
        if (dist[i] == K) {
            cout << i << "\n";
            connected = true;
        }
    }
    if (!connected) cout << -1;

    return 0;
}
