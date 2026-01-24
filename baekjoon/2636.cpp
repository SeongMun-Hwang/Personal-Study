#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>
using namespace std;


int N, M;
int board[100][100];
bool visited[100][100];

int dx[4] = { 1, -1, 0, 0 };
int dy[4] = { 0, 0, 1, -1 };

bool inRange(int x, int y) {
	return x >= 0 && x < N && y >= 0 && y < M;
}


int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	cin >> N >> M;
	for (int i = 0; i < N; i++)
		for (int j = 0; j < M; j++)
			cin >> board[i][j];

	int cnt = 0;
	int lastCheese = 0;

	while (true) {
		for (int i = 0; i < N; i++) {
			for (int j = 0; j < M; j++) {
				visited[i][j] = false;
			}
		}
		queue<pair<int, int>> q;
		q.push({ 0, 0 });
		visited[0][0] = true;

		vector<pair<int, int>> melt;

		while (!q.empty()) {
			int x = q.front().first;
			int y = q.front().second;
			q.pop();
			for (int d = 0; d < 4; d++) {
				int nx = x + dx[d];
				int ny = y + dy[d];
				if (!inRange(nx, ny) || visited[nx][ny]) continue;

				visited[nx][ny] = true;
				if (board[nx][ny] == 1) {
					melt.push_back({ nx, ny });
				}
				else {
					q.push({ nx, ny });
				}
			}
		}

		if (melt.empty()) break;

		lastCheese = melt.size();
		for (auto& p : melt)
			board[p.first][p.second] = 0;
		cnt++;
	}

	cout << cnt << "\n" << lastCheese << "\n";
	return 0;
}