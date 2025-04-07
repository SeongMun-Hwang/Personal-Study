#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>
using namespace std;

pair<int, int> dir[4] = { {0,1}, {1,0}, {0,-1}, {-1,0} };

int Rotate(string s, int dir) {
	if (s == "L") {
		return dir = (dir + 3) % 4;
	}
	else if (s == "D") {
		return dir = (dir + 1) % 4;
	}
	return 0;
}

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0);

	int n;
	cin >> n;
	vector<vector<int>> map(n, vector<int>(n));

	int k;
	cin >> k;
	for (int i = 0; i < k; i++) {
		int x, y;
		cin >> x >> y;
		map[x - 1][y - 1] = 2;
	}


	int l;
	cin >> l;

	queue<pair<int, string>> order;
	for (int i = 0; i < l; i++) {
		int x;
		string c;
		cin >> x >> c;
		order.push({ x, c });		
	}

	int count = 0;
	int moveDir = 0;
	queue<pair<int, int>> snake;
	snake.push({ 0, 0 });
	map[0][0] = 1;

	while (true) {
		count++;
		int x = snake.back().first + dir[moveDir].first;
		int y = snake.back().second + dir[moveDir].second;

		if (x < 0 || y < 0 || x >= n || y >= n || map[x][y]==1) {
			break;
		}
		snake.push({ x, y });
		if (map[x][y] != 2) {
			map[snake.front().first][snake.front().second] = 0;
			snake.pop();
		}
		map[x][y] = 1;

		if (!order.empty() && count == order.front().first) {
			moveDir = Rotate(order.front().second, moveDir);
			order.pop();
		}
	}

	cout << count;
}