#include <iostream>
#include <vector>
#include <cmath>
#include <climits>
#include<algorithm>
#include<numeric>
#include<map>
using namespace std;

vector<int> meats(5);

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	int n;
	cin >> n;

	vector<pair<int, int>> sources(n);
	for (int i = 0; i < n; i++) {
		cin >> sources[i].first >> sources[i].second;
	}
	long long result = LONG_MAX;
	for (int mask = 1; mask < (1 << n); mask++) {
		long long s = 1;
		long long b = 0;

		for (int i = 0; i < n; i++) {
			if (mask & (1 << i)) {
				s *= sources[i].first;
				b += sources[i].second;
			}
		}
		result = min(result, abs(s - b));
	}
	cout << result;
	
	return 0;
}
