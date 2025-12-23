#include <iostream>
#include <vector>
#include <algorithm>
#include <map>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	int N, K;
	cin >> N >> K;

	vector<int> cats(N);
	for (int i = 0; i < N; i++) {
		cin >> cats[i];
	}
	sort(cats.begin(), cats.end());

	int l = 0, r = N - 1;
	int cnt = 0;
	while (l < r) {
		if (cats[l] + cats[r] <= K) {
			cnt++;
			l++;
			r--;
		}
		else {
			r--;
		}
	}
	cout << cnt;

	return 0;
}