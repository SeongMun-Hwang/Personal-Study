#include <iostream>
#include <vector>
#include <cmath>
#include <climits>
#include<algorithm>
#include<numeric>
#include<map>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	int n;
	cin >> n;
	long long total = 0;
	long long maxh = 0;
	vector<long long> server(n * n);
	for (int i = 0; i < n * n; i++) {
		cin >> server[i];
		total += server[i];
		maxh = max(maxh, server[i]);
	}

	long long left = 0, right = maxh;

	while (left <= right) {
		long long mid = (left + right) / 2;
		long long sum = 0;
		for (auto x : server) sum += min(x, mid);
		if (sum * 2 >= total) right = mid - 1;
		else left = mid + 1;
	}
	cout << left;
	return 0;
}