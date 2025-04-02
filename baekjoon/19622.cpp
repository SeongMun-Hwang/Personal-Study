#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

struct Meeting {
	int start;
	int end;
	int people;
};

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0);

	int n;
	cin >> n;

	vector<Meeting> meetings(n);
	for (int i = 0; i < n; i++) {
		cin >> meetings[i].start >> meetings[i].end >> meetings[i].people;
	}
	sort(meetings.begin(), meetings.end(), [](const Meeting& a, const Meeting& b) {
		return a.end < b.end;
		});

	vector<int> dp(n, 0);
	dp[0] = meetings[0].people;
	for (int i = 1; i < n; i++) {
		int include = meetings[i].people;
		for (int j = i - 1; j >= 0; j--) {
			if (meetings[j].end <= meetings[i].start) {
				include += dp[j];
				break;
			}
		}
		dp[i] = max(dp[i - 1], include);
	}
	cout << dp[n-1];
	return 0;
}