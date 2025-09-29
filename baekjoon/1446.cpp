#include <iostream>
#include <stack>
#include <vector>
#include <string>
#include <limits.h>
using namespace std;

struct Shortcut {
	int start, end, length;
};

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	int N, D;
	cin >> N >> D;
	vector<Shortcut> shortcuts;
	for (int i = 0; i < N; i++) {
		int s, e, l;
		cin >> s >> e >> l;
		if (e - s > l && e <= D) {
			shortcuts.push_back({ s,e,l });
		}
	}
	vector<int> dp(D + 1, INT_MAX);
	dp[0] = 0;
	
	for (int i = 0; i <= D; i++) {
		if (i > 0) dp[i] = min(dp[i], dp[i - 1] + 1);
		for (auto& sc : shortcuts) {
			if (sc.start == i) {
				dp[sc.end] = min(dp[sc.end], dp[i] + sc.length);
			}
		}
	}
	cout << dp[D];
	return 0;
}