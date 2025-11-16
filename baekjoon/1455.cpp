#include <iostream>
#include <vector>
#include <cmath>
#include <climits>
#include<algorithm>
#include<string>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	int N, M;
	cin >> N >> M;

	vector<vector<int>> coin(N, vector<int>(M));
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < M; j++) {
			char c;
			cin >> c;
			coin[i][j] = c - '0';
		}
	}

	int cnt = 0;
	for (int i = N - 1; i >= 0; i--) {
		for (int j = M - 1; j >= 0; j--) {
			if (coin[i][j] == 1) {
				cnt++;
				for (int x = 0; x <= i; x++) {
					for (int y = 0; y <= j; y++) {
						coin[x][y] = 1 - coin[x][y];
					}
				}
			}
		}
	}
	cout << cnt;

	return 0;
}
