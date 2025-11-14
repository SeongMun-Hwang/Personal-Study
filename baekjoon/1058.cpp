#include <iostream>
#include <vector>
#include <cmath>
#include <climits>
#include<algorithm>
#include<queue>
using namespace std;

int N;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	cin >> N;
	vector<string> friends(N);
	for (int i = 0; i < N; i++) {
			cin >> friends[i];
	}

	int maxCount = 0;
	for (int i = 0; i < N; i++) {
		vector<bool> isFriend(N, false);

		for (int j = 0; j < N; j++) {
			if (i == j) continue;
			if (friends[i][j] == 'Y') {
				isFriend[j] = true;
			}
			else {
				for (int k = 0; k < N; k++) {
					if (friends[i][k] == 'Y' && friends[k][j] == 'Y') {
						isFriend[j] = true;
						break;
					}
				}
			}
		}
		int cnt = 0;
		for (bool x : isFriend) {
			if (x) cnt++;
		}
		maxCount = max(maxCount, cnt);
	}
	cout << maxCount;

	return 0;
}
