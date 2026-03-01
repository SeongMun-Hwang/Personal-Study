#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int N, M;
    cin >> N >> M;

    vector<string> campus(N);
    for (int i = 0; i < N; i++)
        cin >> campus[i];

    queue<pair<int, int>> q;
    vector<vector<bool>> visited(N, vector<bool>(M, false));

    int sx, sy;

    for (int i = 0; i < N; i++) {
        for (int j = 0; j < M; j++) {
            if (campus[i][j] == 'I') {
                sx = i;
                sy = j;
            }
        }
    }

    q.push({ sx, sy });
    visited[sx][sy] = true;

    int dx[4] = { 1, -1, 0, 0 };
    int dy[4] = { 0, 0, 1, -1 };

    int count = 0;

    while (!q.empty()) {
        pair<int, int> cur = q.front();
        q.pop();

        int x = cur.first;
        int y = cur.second;

        if (campus[x][y] == 'P')
            count++;

        for (int d = 0; d < 4; d++) {
            int nx = x + dx[d];
            int ny = y + dy[d];

            if (nx < 0 || ny < 0 || nx >= N || ny >= M) continue;
            if (visited[nx][ny]) continue;
            if (campus[nx][ny] == 'X') continue;

            visited[nx][ny] = true;
            q.push({ nx, ny });
        }
    }

    if (count == 0) cout << "TT\n";
    else cout << count << "\n";
}