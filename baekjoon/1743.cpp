#include <iostream>
#include <queue>
using namespace std;

int N, M, K;
int grid[101][101];
bool visited[101][101];

int dx[4] = {1, -1, 0, 0};
int dy[4] = {0, 0, 1, -1};

int bfs(int x, int y) {
    queue<pair<int, int>> q;
    q.push({x, y});
    visited[x][y] = true;

    int size = 1;

    while (!q.empty()) {
        auto [cx, cy] = q.front();
        q.pop();

        for (int i = 0; i < 4; i++) {
            int nx = cx + dx[i];
            int ny = cy + dy[i];

            if (nx < 1 || ny < 1 || nx > N || ny > M) continue;
            if (visited[nx][ny]) continue;
            if (grid[nx][ny] == 0) continue;

            visited[nx][ny] = true;
            q.push({nx, ny});
            size++;
        }
    }

    return size;
}

int main() {
    cin >> N >> M >> K;

    for (int i = 0; i < K; i++) {
        int r, c;
        cin >> r >> c;
        grid[r][c] = 1;
    }

    int answer = 0;

    for (int i = 1; i <= N; i++) {
        for (int j = 1; j <= M; j++) {
            if (grid[i][j] == 1 && !visited[i][j]) {
                answer = max(answer, bfs(i, j));
            }
        }
    }

    cout << answer << endl;
    return 0;
}