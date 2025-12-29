#include <iostream>
#include <vector>
#include <algorithm>
#include <stack>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	int N, X;
	cin >> N >> X;

	vector<long long> v(N + 1);
	for (int i = 1; i < N + 1; i++) {
		int num;
		cin >> num;
		v[i] = num + v[i - 1];
	}

	int max_sum = 0;
	int cnt = 0;

	for (int i = X; i <= N; i++) {
		long long visit = v[i] - v[i - X];
		if (max_sum < visit) {
			max_sum = visit;
			cnt = 1;
		}
		else if (max_sum == visit) {
			cnt++;
		}
	}
	if (max_sum == 0) cout << "SAD";
	else cout << max_sum << "\n" << cnt;

	return 0;
}