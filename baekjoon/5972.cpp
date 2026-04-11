#include <iostream>
#include <vector>
#include <queue>
#include <algorithm>

using namespace std;

const int INF = 1e9;

int N, M;
vector<pair<int,int>> adj[50001];
int dist[50001];

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    cin >> N >> M;

    for(int i = 0; i < M; i++) {
        int A, B, C;
        cin >> A >> B >> C;
        adj[A].push_back({B, C});
        adj[B].push_back({A, C});
    }

    priority_queue<pair<int,int>, vector<pair<int,int>>, greater<pair<int,int>>> pq;

    fill(dist, dist + N + 1, INF);
    dist[1] = 0;
    pq.push({0, 1});

    while(!pq.empty()) {
        int cost = pq.top().first;
        int cur = pq.top().second;
        pq.pop();

        if(cost > dist[cur]) continue;

        for(auto &edge : adj[cur]) {
            int next = edge.first;
            int w = edge.second;

            if(dist[next] > cost + w) {
                dist[next] = cost + w;
                pq.push({dist[next], next});
            }
        }
    }

    cout << dist[N] << '\n';
    return 0;
}