#include <iostream>
#include <vector>
#include <algorithm>
#include <numeric>
#include <cmath>
using namespace std;

int N, M;

int main() {
	cin >> N >> M;
	vector<int> lamp;

	while (M--) {
		int n;
		cin >> n;
		lamp.push_back(n);
	}
	int max_height = max(lamp[0], N - lamp[lamp.size() - 1]);
	for (int i = 1; i < lamp.size(); i++) {
		max_height = max(max_height, (int)ceil((lamp[i] - lamp[i - 1]) / 2.0));
	}
	cout << max_height;
	return 0;
}