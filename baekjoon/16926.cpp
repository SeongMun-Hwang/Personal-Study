#include <iostream>
#include <vector>
#include <algorithm>
#include <numeric>
#include <deque>
using namespace std;

int N, M, R;

int main() {
	cin >> N >> M >> R;
	deque<int> dq;
	vector<vector<int>> v(N, vector<int>(M));
	int cnt = min(N,M)/2;
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < M; j++) {
			cin >> v[i][j];
		}
	}

	for (int i = 0; i < cnt; i++) {
		int top = i, left = i;
		int bottom = N - i - 1, right = M - i - 1;

		for (int j = left; j <= right; j++) dq.push_back(v[top][j]);
		for (int j = top + 1; j <= bottom; j++) dq.push_back(v[j][right]);
		for (int j = right -1; j >= left; j--) dq.push_back(v[bottom][j]);
		for (int j = bottom -1; j > top; j--) dq.push_back(v[j][left]);

		for (int j = 0; j < R; j++) {
			int tmp = dq.front();
			dq.pop_front();
			dq.push_back(tmp);
		}

		for (int j = left; j <= right; j++) {
			v[top][j] = dq.front();
			dq.pop_front();
		}
		for (int j = top + 1; j <= bottom; j++) {
			v[j][right] = dq.front();
			dq.pop_front();
		}
		for (int j = right - 1; j >= left; j--) {
			v[bottom][j] = dq.front();
			dq.pop_front();
		}
		for (int j = bottom - 1; j > top; j--) {
			v[j][left] = dq.front();
			dq.pop_front();
		}
	}
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < M; j++) {
			cout << v[i][j] <<" ";
		}
		cout << "\n";
	}
	return 0;
}