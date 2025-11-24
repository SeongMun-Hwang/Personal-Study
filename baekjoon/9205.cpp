#include <iostream>
#include <vector>
#include <cmath>
#include <climits>
#include<algorithm>
#include<queue>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	int t;
	cin >> t;

	while (t--) {
		int n;
		cin >> n;

		vector<pair<int, int>> pos(n+2);

		for (int i = 0; i < n+2; i++) {
			cin >> pos[i].first >> pos[i].second;
		}

		queue<int> q;
		vector<bool> visited(n + 2, false);
		bool isHappy = false;
		q.push(0);
		visited[0] = true;

		while(!q.empty()) {
			int cur = q.front();
			q.pop();

			if (cur == n + 1) {
				isHappy = true;
				break;
			}

			for (int i = 0; i < n + 2; i++) {
				if (!visited[i]) {
					int length = abs(pos[cur].first - pos[i].first) + abs(pos[cur].second - pos[i].second);
					if (length <= 1000) {
						q.push(i);
						visited[i] = true;
					}
				}
			}
		}
		if (isHappy) cout << "happy\n";
		else cout << "sad\n";
	}

	return 0;
}
