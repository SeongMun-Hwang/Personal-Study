#include <iostream>
#include <vector>
#include <cmath>
#include <climits>
#include<algorithm>
#include<queue>
using namespace std;

int R, C, K;
vector<vector<char>> map;
vector<vector<bool>> isVisited;
int dr[4] = { 1,-1,0,0 };
int dc[4] = { 0,0,1,-1 };
int cnt = 0;

void dfs(int r, int c, int k) {
	if (r == 0 && c == C - 1) {
		if (k == K) {
			cnt++;
			return;
		}
	}

	if (k >= K) return;

	for (int i = 0; i < 4; i++) {
		int nr = r + dr[i];
		int nc = c + dc[i];

		if (nr < 0 || nr >= R || nc < 0 || nc >= C)continue;
		if (isVisited[nr][nc]) continue;
		if (map[nr][nc] == 'T') continue;

		isVisited[nr][nc] = true;
		dfs(nr, nc, k + 1);
		isVisited[nr][nc] = false;
	}
}

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	cin >> R >> C >> K;
	map.resize(R, vector<char>(C));
	isVisited.resize(R, vector<bool>(C, false));

	for (int i = 0; i < R; i++) {
		for (int j = 0; j < C; j++) {
			cin >> map[i][j];
		}
	}
	isVisited[R - 1][0] = true;
	dfs(R - 1, 0, 1);

	cout << cnt;

	return 0;
}
